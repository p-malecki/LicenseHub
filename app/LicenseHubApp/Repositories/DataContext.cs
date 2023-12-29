using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using LicenseHubApp.Models;


namespace LicenseHubApp.Repositories
{
    public class DataContext : DbContext
    {
        public virtual DbSet<UserModel> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile($"appsettings.json", true, true);

            var config = builder.Build();

            optionsBuilder
                .UseSqlite(config["ConnectionString"]);
        }
    }
}
