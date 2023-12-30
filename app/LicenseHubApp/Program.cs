using LicenseHubApp.Models;
using LicenseHubApp.Repositories;
using Microsoft.Data.Sqlite;
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
            // create connectionString with absolute path to [project]\Data\database.db
            var connectionString = "";
            var solutionDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            var path = Path.Combine(solutionDirectory, "Data\\database.db");

            var builder = new SqliteConnectionStringBuilder(connectionString);
            builder.DataSource = Path.GetFullPath(
                Path.Combine(path, builder.DataSource));
            connectionString = builder.ToString();

            System.Configuration.ConfigurationManager.AppSettings["ConnectionString"] = connectionString;


            ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());




            var dataContext = new DataContext();
            if (!dataContext.IsDatabaseConnected())
                throw new Exception("Database is not connected.");


            IUserRepository repository = new UserRepository(dataContext);
            var user = new UserModel() { Id = 123, Name = "abcd", Password = "Password1#", IsAdmin = false };


            repository.Add(user);
            var all = repository.GetAll().Result.ToList();
            foreach (var u in all)
                Console.WriteLine(u.Id);


            repository.Delete(user);
            all = repository.GetAll().Result.ToList();
            foreach (var u in all)
                Console.WriteLine(u.Id);

        }
    }
}