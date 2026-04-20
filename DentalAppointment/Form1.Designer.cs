namespace DentalAppointment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            FullNameTextBox = new TextBox();
            label2 = new Label();
            PhoneNumberTextBox = new TextBox();
            DoctorComboBox = new ComboBox();
            label3 = new Label();
            AppointmentDateTimePicker = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            OfficeLocationComboBox = new ComboBox();
            ComformAppointmentButton = new Button();
            label6 = new Label();
            ReasonForVisitTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 43);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Full Name";
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new Point(154, 43);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.PlaceholderText = "LastName, FirstName";
            FullNameTextBox.Size = new Size(273, 23);
            FullNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 100);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 2;
            label2.Text = "Phone Number";
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Location = new Point(154, 95);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(105, 23);
            PhoneNumberTextBox.TabIndex = 3;
            // 
            // DoctorComboBox
            // 
            DoctorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DoctorComboBox.FormattingEnabled = true;
            DoctorComboBox.Location = new Point(154, 147);
            DoctorComboBox.Name = "DoctorComboBox";
            DoctorComboBox.Size = new Size(121, 23);
            DoctorComboBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 152);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 5;
            label3.Text = "Doctor";
            // 
            // AppointmentDateTimePicker
            // 
            AppointmentDateTimePicker.Location = new Point(154, 204);
            AppointmentDateTimePicker.Name = "AppointmentDateTimePicker";
            AppointmentDateTimePicker.Size = new Size(200, 23);
            AppointmentDateTimePicker.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 207);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 7;
            label4.Text = "Apointment Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 253);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 8;
            label5.Text = "Office Location";
            // 
            // OfficeLocationComboBox
            // 
            OfficeLocationComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            OfficeLocationComboBox.FormattingEnabled = true;
            OfficeLocationComboBox.Location = new Point(154, 253);
            OfficeLocationComboBox.Name = "OfficeLocationComboBox";
            OfficeLocationComboBox.Size = new Size(121, 23);
            OfficeLocationComboBox.TabIndex = 9;
            // 
            // ComformAppointmentButton
            // 
            ComformAppointmentButton.Location = new Point(94, 408);
            ComformAppointmentButton.Name = "ComformAppointmentButton";
            ComformAppointmentButton.Size = new Size(233, 92);
            ComformAppointmentButton.TabIndex = 10;
            ComformAppointmentButton.Text = "Conform Appointment";
            ComformAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 299);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 11;
            label6.Text = "Reason For Visit";
            // 
            // ReasonForVisitTextBox
            // 
            ReasonForVisitTextBox.Location = new Point(154, 296);
            ReasonForVisitTextBox.Multiline = true;
            ReasonForVisitTextBox.Name = "ReasonForVisitTextBox";
            ReasonForVisitTextBox.Size = new Size(218, 75);
            ReasonForVisitTextBox.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 525);
            Controls.Add(ReasonForVisitTextBox);
            Controls.Add(label6);
            Controls.Add(ComformAppointmentButton);
            Controls.Add(OfficeLocationComboBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(AppointmentDateTimePicker);
            Controls.Add(label3);
            Controls.Add(DoctorComboBox);
            Controls.Add(PhoneNumberTextBox);
            Controls.Add(label2);
            Controls.Add(FullNameTextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Schedule Doctor Appointment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox FullNameTextBox;
        private Label label2;
        private TextBox PhoneNumberTextBox;
        private ComboBox DoctorComboBox;
        private Label label3;
        private DateTimePicker AppointmentDateTimePicker;
        private Label label4;
        private Label label5;
        private ComboBox OfficeLocationComboBox;
        private Button ComformAppointmentButton;
        private Label label6;
        private TextBox ReasonForVisitTextBox;
    }
}
