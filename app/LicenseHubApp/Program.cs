using LicenseHubApp.Models;
using LicenseHubApp.Presenters;
using LicenseHubApp.Repositories;
using LicenseHubApp.Services;
using LicenseHubApp.Views.Forms;
using Microsoft.Data.Sqlite;


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


            // Repository and manager needed to log in
            IUserRepository userRepository = new UserRepository(dataContext);
            var authenticationManager = AuthenticationManager.GetInstance(userRepository);


            var loginForm = LoginFormView.GetInstance(null);
            var loginPresenter = new LoginPresenter(loginForm, authenticationManager, dataContext, userRepository);


            // Run main loop
            Application.Run(loginForm);


            // DEBUG database quick actions
            //var user = new UserModel() { Id = 0, Username = "admin", Password = "Admin123@", IsAdmin = true };
            //repository.AddAsync(user);
        }
    }
}