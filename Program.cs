using Assignment_10._3.Data;
using Microsoft.EntityFrameworkCore;

namespace Assignment_10._3
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Records.context = new CarContext();
            //Records.context.Database.EnsureDeleted(); // Uncomment when testing; will delete database and recreate with seed data
            Records.context.Database.EnsureCreated();
            Records.context.Cars.Load();
            Records.context.Dealerships.Load();
            Application.Run(new Form1());
        }
    }
}