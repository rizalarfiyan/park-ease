using ParkEase.Model.Entity;
using ParkEase.View;

namespace ParkEase
{
    public delegate void LoadDataEvenHandler();

    internal static class Program
    {
        public static User? UserData = null;
        public static string? UserToken = null;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScreen());
        }
    }
}