using Microsoft.Extensions.Configuration;

namespace LicenseHubApp
{
    internal static class Program
    {
        public static IConfiguration Configuration;


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main(string[] args)
        {
            //To register all default providers:
            var builder = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();

            ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());

        }
    }
}