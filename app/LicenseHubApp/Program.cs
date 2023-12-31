using LicenseHubApp.Models;
using LicenseHubApp.Models.ModelManagers;
using LicenseHubApp.Presenters;
using LicenseHubApp.Repositories;
using LicenseHubApp.Views.Forms;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;


namespace LicenseHubApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();


            // Create connectionString with absolute path to [project]\Data\database.db
            var connectionString = "";
            var solutionDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            var path = Path.Combine(solutionDirectory, "Data\\database.db");

            var builder = new SqliteConnectionStringBuilder(connectionString);
            builder.DataSource = Path.GetFullPath(
                Path.Combine(path, builder.DataSource));
            connectionString = builder.ToString();
            System.Configuration.ConfigurationManager.AppSettings["ConnectionString"] = connectionString;


            // Database
            var dataContext = new DataContext();
            if (!dataContext.IsDatabaseConnected())
                throw new Exception("Database is not connected.");

            // Repositories
            IUserRepository repository = new UserRepository(dataContext);

            // Utils
            var authenticationManager = AuthenticationManager.GetInstance(repository);

            var loginForm = new LoginForm();
            var loginPresenter = new LoginPresenter(loginForm, authenticationManager);



            // Run main loop
            Application.Run(loginForm);



            // DEBUG database quick actions
            //var user = new UserModel() { Id = 0, Username = "admin", Password = "Admin123@", IsAdmin = true };
            //repository.AddAsync(user);
        }
    }
}