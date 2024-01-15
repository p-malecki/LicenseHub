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
        
        
        public virtual DbSet<ProductModel> Products { get; set; }
        public virtual DbSet<ProductReleaseModel> ProductReleases { get; set; }

        public virtual DbSet<LicenseModel> Licenses { get; set; }
        public virtual DbSet<ActivationCodeModel> ActivationCodes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //// TPC mapping
            //  use the OfType<TEntity> method to query for particular type

            modelBuilder.Entity<LicenseModel>().UseTpcMappingStrategy();
            modelBuilder.Entity<SubscriptionLicenseModel>().ToTable("SubscriptionLicenses");
            modelBuilder.Entity<PerpetualLicenseModel>().ToTable("PerpetualLicenses");

            modelBuilder.Entity<ActivationCodeModel>().UseTpcMappingStrategy();
            modelBuilder.Entity<GeneratedActivationCodeModel>().ToTable("GeneratedActivationCodes");



            //// relationships

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


            // many releases to one product 
            modelBuilder.Entity<ProductModel>()
                .HasMany(m => m.Releases)
                .WithOne(m => m.Product)
                .HasForeignKey(m => m.ProductId)
                .IsRequired();


            // one activationCode to one License 
            modelBuilder.Entity<LicenseModel>()
                .HasOne(m => m.ActivationCode)
                .WithOne(m => m.License)
                .HasForeignKey<ActivationCodeModel>(m => m.LicenseId)
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