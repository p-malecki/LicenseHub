using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

using LicenseHubApp.Models;


namespace LicenseHubApp.Repositories
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
        }

        public virtual DbSet<UserModel> Users { get; set; }
        public virtual DbSet<CompanyModel> Companies { get; set; }

        public bool IsDatabaseConnected()
        {
            try
            {
                Database.OpenConnection();
                Database.CloseConnection();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<string> GetTables()
        {
            var databaseCreator = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;

            if (databaseCreator != null && databaseCreator.Exists())
            {
                var connection = Database.GetDbConnection();
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT name FROM sqlite_master WHERE type='table';";

                    using (var reader = command.ExecuteReader())
                    {
                        var tables = new List<string>();

                        while (reader.Read())
                        {
                            tables.Add(reader.GetString(0));
                        }

                        return tables;
                    }
                }
            }

            return Enumerable.Empty<string>();
        }

        public void ShowTables()
        {
            try
            {
                Database.OpenConnection();
                var tables = GetTables();
                foreach (var table in tables)
                    Console.WriteLine(table);
                Database.CloseConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}

// make sure that when debugging in bin/Debug/../ must exist Data folder