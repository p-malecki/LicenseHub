using Microsoft.EntityFrameworkCore;
using LicenseHubApp.Models;
using LicenseHubApp.Services;


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
        
        
        public virtual DbSet<ProductModel> Products { get; set; }
        public virtual DbSet<ProductReleaseModel> StoreProductReleases { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // relationships

            // many employees to one company 
            modelBuilder.Entity<CompanyModel>()
                .HasMany(m => m.Employees)
                .WithOne(m => m.Company)
                .HasForeignKey(m => m.CompanyId)
                .IsRequired();

            // many workstations to one company 
            modelBuilder.Entity<CompanyModel>()
                .HasMany(m => m.Workstations)
                .WithOne(m => m.Company)
                .HasForeignKey(m => m.CompanyId)
                .IsRequired();


            // many releases to one storeProduct 
            modelBuilder.Entity<ProductModel>()
                .HasMany(m => m.Releases)
                .WithOne(m => m.Product)
                .HasForeignKey(m => m.ProductId)
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