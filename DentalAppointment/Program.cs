using System;
using System.Windows.Forms;

namespace DentalAppointment
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new Form1());
            }
            catch (Exception ex)
            {
                // If the app fails during startup, show a message box with details so the developer can see the error.
                // This helps when running the WinForms app outside of the debugger.
                MessageBox.Show($"Unhandled exception starting application:\n{ex}", "Startup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
