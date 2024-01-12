using Microsoft.EntityFrameworkCore;
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
        public virtual DbSet<EmployeeModel> Employees { get; set; }
        public virtual DbSet<WorkstationModel> Workstations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // many-to-one relationship
            modelBuilder.Entity<CompanyModel>()
                .HasMany(m => m.Employees)
                .WithOne(m => m.Company)
                .HasForeignKey(m => m.CompanyId)
                .IsRequired();

            // many-to-one relationship
            modelBuilder.Entity<CompanyModel>()
                .HasMany(m => m.Workstations)
                .WithOne(m => m.Company)
                .HasForeignKey(m => m.CompanyId)
                .IsRequired();
        }


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

    }
}

// make sure that when debugging in bin/Debug/../ must exist "Data" folder