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
        public virtual DbSet<ProductStatus1> ProductStatus1s { get; set; }
        public virtual DbSet<ScaleValue> ScaleValues { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=SuplyProgram;Integrated Security=True");
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

            modelBuilder.Entity<ProductStatus1>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("ProductStatus1");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.PackageId).HasColumnName("PackageID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.ProductStatus1s)
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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
