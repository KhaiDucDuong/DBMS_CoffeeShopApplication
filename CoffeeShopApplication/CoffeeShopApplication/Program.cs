using CoffeeShopApplication.Interfaces;

namespace CoffeeShopApplication
{
    internal static class Program
    {
        static Form mainForm = new LogInForm();

        public static Form MainForm { get => mainForm;}
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(MainForm);
        }
    }
}