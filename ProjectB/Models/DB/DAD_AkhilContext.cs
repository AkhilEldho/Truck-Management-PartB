using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ProjectB.Models.DB
{
    public partial class DAD_AkhilContext : DbContext
    {
        public DAD_AkhilContext()
        {
        }

        public DAD_AkhilContext(DbContextOptions<DAD_AkhilContext> options)
            : base(options)
        {
        }

        public virtual DbSet<IndividualTruckPb> IndividualTruckPbs { get; set; }
        public virtual DbSet<TruckCustomerPb> TruckCustomerPbs { get; set; }
        public virtual DbSet<TruckEmployeePb> TruckEmployeePbs { get; set; }
        public virtual DbSet<TruckFeatureAssociationPb> TruckFeatureAssociationPbs { get; set; }
        public virtual DbSet<TruckFeaturePb> TruckFeaturePbs { get; set; }
        public virtual DbSet<TruckModelPb> TruckModelPbs { get; set; }
        public virtual DbSet<TruckPersonPb> TruckPersonPbs { get; set; }
        public virtual DbSet<TruckRentalPb> TruckRentalPbs { get; set; }
        public virtual DbSet<MonthlySales> MonthlySalesPbs { get; set; }
        public virtual DbSet<SearchModelSales> SearchModelSalesPbs { get; set; }
        public virtual DbSet<TopFiveRented> TopFiveRentedPbs { get; set; }
        public virtual DbSet<LeastFiveRentedModel> LeastFiveRentedModelPbs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=citizen.manukautech.info,6306;Initial Catalog=DAD_Akhil;Persist Security Info=True;User ID=DAD_Akhil;Password=Akhil123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IndividualTruckPb>(entity =>
            {
                entity.HasKey(e => e.TruckId);

                entity.ToTable("IndividualTruck-PB");

                entity.Property(e => e.TruckId).HasColumnName("TruckID");

                entity.Property(e => e.AdvanceDepositRequired).HasColumnType("money");

                entity.Property(e => e.Colour)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DailyRentalPrice).HasColumnType("money");

                entity.Property(e => e.DateImported).HasColumnType("date");

                entity.Property(e => e.FuelType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationExpiryDate).HasColumnType("date");

                entity.Property(e => e.RegistrationNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Transmission)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TruckModelId).HasColumnName("TruckModelID");

                entity.Property(e => e.WofexpiryDate)
                    .HasColumnType("date")
                    .HasColumnName("WOFExpiryDate");
            });

            modelBuilder.Entity<TruckCustomerPb>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("TruckCustomer-PB");

                entity.Property(e => e.CustomerId)
                    .ValueGeneratedNever()
                    .HasColumnName("CustomerID");

                entity.Property(e => e.LicenseExpiryDate).HasColumnType("date");

                entity.Property(e => e.LicenseNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TruckEmployeePb>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("TruckEmployee-PB");

                entity.Property(e => e.EmployeeId)
                    .ValueGeneratedNever()
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.OfficeAddress)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneExtensionNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TruckFeatureAssociationPb>(entity =>
            {
                entity.HasKey(e => new { e.TruckId, e.FeatureId });

                entity.ToTable("Truck_Feature_Association-PB");

                entity.Property(e => e.TruckId).HasColumnName("TruckID");

                entity.Property(e => e.FeatureId).HasColumnName("FeatureID");
            });

            modelBuilder.Entity<TruckFeaturePb>(entity =>
            {
                entity.HasKey(e => e.FeatureId);

                entity.ToTable("TruckFeature-PB");

                entity.Property(e => e.FeatureId).HasColumnName("FeatureID");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TruckModelPb>(entity =>
            {
                entity.HasKey(e => e.ModelId);

                entity.ToTable("TruckModel-PB");

                entity.Property(e => e.ModelId).HasColumnName("ModelID");

                entity.Property(e => e.Manufacturer)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Size)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TruckPersonPb>(entity =>
            {
                entity.HasKey(e => e.PersonId);

                entity.ToTable("TruckPerson-PB");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TruckRentalPb>(entity =>
            {
                entity.HasKey(e => e.RentalId);

                entity.ToTable("TruckRental-PB");

                entity.Property(e => e.RentalId).HasColumnName("RentalID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.RentDate).HasColumnType("date");

                entity.Property(e => e.ReturnDate).HasColumnType("date");

                entity.Property(e => e.ReturnDueDate).HasColumnType("date");

                entity.Property(e => e.TotalPrice).HasColumnType("money");

                entity.Property(e => e.TruckId).HasColumnName("TruckID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
