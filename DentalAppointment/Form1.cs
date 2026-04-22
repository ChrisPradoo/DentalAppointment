using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DentalAppointment;

public partial class Form1 : Form
{
    // Simple in-memory model for a doctor. Kept inside the form for this small sample.
    private class Doctor
    {
        public string Name { get; set; } = string.Empty;
        public string Specialty { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        // Display a friendly string in the ComboBox
        public override string ToString() => $"{Name} ({Specialty})";
    }

    public Form1()
    {
        InitializeComponent();

        // Populate UI lists with sample data when the form is created.
        PopulateDoctors();
        PopulateOfficeLocations();

        // Wire up the confirm button click to perform validation and confirmation.
        ComformAppointmentButton.Click += ComformAppointmentButton_Click;
    }

    /// <summary>
    /// Populate the doctor ComboBox with realistic sample data.
    /// In a real app this would come from a database or API.
    /// </summary>
    private void PopulateDoctors()
    {
        var doctors = new List<Doctor>
        {
            new Doctor { Name = "Dr. Sarah Lee", Specialty = "General Dentistry", Phone = "(206) 555-0142", Email = "sarah.lee@dentalcare.example" },
            new Doctor { Name = "Dr. Miguel Hernandez", Specialty = "Orthodontics", Phone = "(206) 555-0189", Email = "miguel.h@dentalcare.example" },
            new Doctor { Name = "Dr. Priya Patel", Specialty = "Pediatric Dentistry", Phone = "(206) 555-0123", Email = "priya.p@dentalcare.example" }
        };

        // Clear any existing items and set the list as the data source for simplicity.
        DoctorComboBox.Items.Clear();
        DoctorComboBox.Items.AddRange(doctors.Cast<object>().ToArray());

        // Select the first doctor by default if available.
        if (DoctorComboBox.Items.Count > 0)
            DoctorComboBox.SelectedIndex = 0;
    }

    /// <summary>
    /// Populate the office locations ComboBox with sample addresses.
    /// </summary>
    private void PopulateOfficeLocations()
    {
        var locations = new[]
        {
            "Main Office - 123 Main St, Lakewood, WA",
            "West Branch - 456 Oak Ave, Lakewood, WA",
            "Downtown Clinic - 789 Market St, Lakewood, WA"
        };

        OfficeLocationComboBox.Items.Clear();
        OfficeLocationComboBox.Items.AddRange(locations);

        if (OfficeLocationComboBox.Items.Count > 0)
            OfficeLocationComboBox.SelectedIndex = 0;
    }

    /// <summary>
    /// Button click handler: validate the appointment data and prompt the user to confirm.
    /// </summary>
    private void ComformAppointmentButton_Click(object? sender, EventArgs e)
    {
        // Basic validation: require name, valid phone, selected doctor and location, date/time in future.
        var fullName = FullNameTextBox.Text?.Trim() ?? string.Empty;
        var phone = PhoneNumberTextBox.Text?.Trim() ?? string.Empty;

        if (string.IsNullOrWhiteSpace(fullName))
        {
            MessageBox.Show(this, "Please enter the patient's full name.", "Missing Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!IsValidPhone(phone))
        {
            MessageBox.Show(this, "Please enter a valid phone number (7 or 10 digits).", "Invalid Phone", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (DoctorComboBox.SelectedItem is not Doctor selectedDoctor)
        {
            MessageBox.Show(this, "Please select a doctor from the list.", "Missing Doctor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (OfficeLocationComboBox.SelectedItem is not string selectedLocation)
        {
            MessageBox.Show(this, "Please select an office location.", "Missing Location", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var appointmentDate = AppointmentDateTimePicker.Value;
        if (appointmentDate < DateTime.Now)
        {
            MessageBox.Show(this, "Please choose an appointment date/time in the future.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // Build a confirmation message summarizing the appointment details.
        var message = $"Confirm appointment for {fullName}\n" +
                      $"Doctor: {selectedDoctor.Name} ({selectedDoctor.Specialty})\n" +
                      $"Location: {selectedLocation}\n" +
                      $"When: {appointmentDate:f}\n" +
                      $"Phone: {phone}\n\n" +
                      "Do you want to confirm this appointment?";

        // Ask the user to confirm (Yes/No). If they confirm, show a success message with a reference id.
        var result = MessageBox.Show(this, message, "Confirm Appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            // In a real app you would persist the appointment to a database here. We generate a simple reference id.
            var referenceId = Guid.NewGuid().ToString("N").ToUpperInvariant().Substring(0, 8);
            MessageBox.Show(this, $"Appointment confirmed. Reference: {referenceId}", "Appointment Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Optionally clear or reset form fields after confirmation. Keep the doctor/location but clear the name and reason.
            FullNameTextBox.Clear();
            PhoneNumberTextBox.Clear();
            ReasonForVisitTextBox.Clear();
            AppointmentDateTimePicker.Value = DateTime.Now.AddDays(1);
        }
    }

    private static bool IsValidPhone(string phoneNumber)
    {
        if (string.IsNullOrWhiteSpace(phoneNumber))
            return false;

        // Extract digits only (ignore punctuation/spaces)
        string digits = new string(phoneNumber.Where(char.IsDigit).ToArray());

        // Must be 7 digits (no area code) or 10 digits (with area code)
        if (digits.Length != 7 && digits.Length != 10)
            return false;

        // Regex patterns for allowed formats (these operate on the original input)
        string[] patterns =
        {
            // 10-digit formats
            @"^\d{3}\.\d{3}\.\d{4}$",
            @"^\(\d{3}\)\s?\d{3}[- ]?\d{4}$",
            @"^\d{10}$",

            // 7-digit formats (area code optional)
            @"^\d{3}[- .]?\d{4}$"
        };

        // Returns true if the phone number matches any of the valid patterns
        return patterns.Any(p => Regex.IsMatch(phoneNumber, p));
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }
}
