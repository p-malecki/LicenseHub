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
        public virtual DbSet<WorkstationProductModel> WorkstationProducts { get; set; }
        public virtual DbSet<OrderModel> Orders { get; set; }
        
        
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

            // many Employees to one Company 
            modelBuilder.Entity<CompanyModel>()
                .HasMany(m => m.Employees)
                .WithOne(m => m.Company)
                .HasForeignKey(m => m.CompanyId)
                .IsRequired();

            // many Workstations to one Company 
            modelBuilder.Entity<CompanyModel>()
                .HasMany(m => m.Workstations)
                .WithOne(m => m.Company)
                .HasForeignKey(m => m.CompanyId)
                .IsRequired();

            // many Orders to one Company 
            modelBuilder.Entity<CompanyModel>()
                .HasMany(m => m.Orders)
                .WithOne(m => m.Company)
                .HasForeignKey(m => m.CompanyId)
                .IsRequired();


            // many Releases to one Product 
            modelBuilder.Entity<ProductModel>()
                .HasMany(m => m.Releases)
                .WithOne(m => m.Product)
                .HasForeignKey(m => m.ProductId)
                .IsRequired();


            // one ActivationCode to one License 
            modelBuilder.Entity<LicenseModel>()
                .HasOne(m => m.ActivationCode)
                .WithOne(m => m.License)
                .HasForeignKey<ActivationCodeModel>(m => m.LicenseId)
                .IsRequired();

            // many WorkstationProducts to one Releases
            modelBuilder.Entity<ProductReleaseModel>()
                .HasMany(m => m.WorkstationProducts)
                .WithOne(m => m.ProductRelease)
                .HasForeignKey(m => m.ReleaseId)
                .IsRequired();

            // one License to one WorkstationProduct 
            modelBuilder.Entity<WorkstationProductModel>()
                .HasOne(m => m.License)
                .WithOne(m => m.WorkstationProduct)
                .HasForeignKey<LicenseModel>(m => m.WorkstationProductId)
                .IsRequired();

            // many WorkstationProducts to one Order
            modelBuilder.Entity<OrderModel>()
                .HasMany(m => m.WorkstationProducts)
                .WithOne(m => m.Order)
                .HasForeignKey(m => m.OrderId)
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