using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DataBase.SupplyData
{
    public partial class SuplyProgramContext : DbContext
    {
        public SuplyProgramContext()
        {
        }

        public SuplyProgramContext(DbContextOptions<SuplyProgramContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Package> Packages { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductStatus> ProductStatus1s { get; set; }
        public virtual DbSet<ScaleValue> ScaleValues { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=SuplyProg;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>(entity =>
            {
                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.Location1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Location");
            });

            modelBuilder.Entity<Package>(entity =>
            {
                entity.Property(e => e.PackageId).HasColumnName("PackageID");

                entity.Property(e => e.PackageType).HasMaxLength(50);

                entity.Property(e => e.ScaleId).HasColumnName("ScaleID");

                entity.HasOne(d => d.Scale)
                    .WithMany(p => p.Packages)
                    .HasForeignKey(d => d.ScaleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Packages_ScaleValue");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductName).HasMaxLength(50);
            });

            modelBuilder.Entity<ProductStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("ProductStatus1");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.PackageId).HasColumnName("PackageID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.ProductStatuss)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_ProductStatus1_Locations");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.ProductStatus1s)
                    .HasForeignKey(d => d.PackageId)
                    .HasConstraintName("FK_ProductStatus1_Packages");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductStatus1s)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ProductStatus1_Products");
            });

            modelBuilder.Entity<ScaleValue>(entity =>
            {
                entity.HasKey(e => e.ScaleId);

                entity.ToTable("ScaleValue");

                entity.Property(e => e.ScaleId).HasColumnName("ScaleID");

                entity.Property(e => e.ScalesTypes).HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UsersId);

                entity.Property(e => e.UsersId).HasColumnName("UsersID");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            #region LocationBasic
            modelBuilder.Entity<Location>().HasData(
                new Location { LocationId = 1, Location1 = "HOME 1" } ,
                new Location { LocationId = 2, Location1 = "HOME 2" },
                new Location { LocationId = 3, Location1 = "STORE" }
                );
          
            #endregion

            #region ProductBasic
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 1, ProductName = "Black peppercorns" },
                new Product { ProductId = 2, ProductName = "Ground cinnamon" },
                new Product { ProductId = 3, ProductName = "Chili powder" },
                new Product { ProductId = 4, ProductName = "Hot-red-chili flakes" }, 
                new Product { ProductId = 5, ProductName = "Cumin" },
                new Product { ProductId = 6, ProductName = "Ground ginger" },
                new Product { ProductId = 7, ProductName = "Spicy Paprika" }
                );
            #endregion

            #region ScaleBasic
            modelBuilder.Entity<ScaleValue>().HasData(
                new ScaleValue { ScaleId = 1, ScalesTypes = "5 kg" },
                new ScaleValue { ScaleId = 2, ScalesTypes = "10 kg" },
                new ScaleValue { ScaleId = 3, ScalesTypes = "500 g" },
                new ScaleValue { ScaleId = 4, ScalesTypes = "300 g" },
                new ScaleValue { ScaleId = 5, ScalesTypes = "100 g" }
                );
            #endregion

            #region PackageBasic
            modelBuilder.Entity<Package>().HasData(
                new Package { PackageId = 1, PackageType = "BOX 1", ScaleId = 1 },
                new Package { PackageId = 2, PackageType = "BOX 3", ScaleId = 2 },
                new Package { PackageId = 3, PackageType = "Bag 1", ScaleId = 1 },
                new Package { PackageId = 4, PackageType = "Bag 2", ScaleId = 5 },
                new Package { PackageId = 5, PackageType = "Small Bag 1", ScaleId = 2 },
                new Package { PackageId = 6, PackageType = "Small Bag 2", ScaleId = 3 },
                new Package { PackageId = 7, PackageType = "BOX 3", ScaleId = 4 }
                );
         
            #endregion

            #region ProductStatusBasic
            modelBuilder.Entity<ProductStatus>().HasData(
                new ProductStatus { StatusId = 1, LocationId = 1, ProductId = 2, PackageId = 3, UnitInstock = 10, UnitinOrder = 30 },
                new ProductStatus { StatusId = 2, LocationId = 1, ProductId = 5, PackageId = 1, UnitInstock = 15, UnitinOrder = 30 },
                new ProductStatus { StatusId = 3, LocationId = 2, ProductId = 3, PackageId = 3, UnitInstock = 20, UnitinOrder = 25 },
                new ProductStatus { StatusId = 4, LocationId = 3, ProductId = 6, PackageId = 4, UnitInstock = 15, UnitinOrder = 16 },
                new ProductStatus { StatusId = 5, LocationId = 2, ProductId = 3, PackageId = 1, UnitInstock = 15, UnitinOrder = 30 },
                new ProductStatus { StatusId = 6, LocationId = 1, ProductId = 1, PackageId = 1, UnitInstock = 10, UnitinOrder = 15 }
                );
            #endregion

            #region UsersBasic
            modelBuilder.Entity<User>().HasData(
                new User { UsersId = 1, Username = "Admin", Password = "Aa123456", Email = "admin@gmail.com", Admin = true },
                new User { UsersId = 2, Username = "User1", Password = "Aa123456", Email = "User2@gmail.com", Admin = true }
                );
            
            #endregion
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
