// <auto-generated />
using System;
using DataBase.SupplyData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataBase.Migrations
{
    [DbContext(typeof(SuplyProgramContext))]
    [Migration("20220303171723_update03032022")]
    partial class update03032022
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("DataBase.SupplyData.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("LocationID")
                        .UseIdentityColumn();

                    b.Property<string>("Location1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Location");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            LocationId = 1,
                            Location1 = "HOME 1"
                        },
                        new
                        {
                            LocationId = 2,
                            Location1 = "HOME 2"
                        },
                        new
                        {
                            LocationId = 3,
                            Location1 = "STORE"
                        });
                });

            modelBuilder.Entity("DataBase.SupplyData.Package", b =>
                {
                    b.Property<int>("PackageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PackageID")
                        .UseIdentityColumn();

                    b.Property<string>("PackageType")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ScaleId")
                        .HasColumnType("int")
                        .HasColumnName("ScaleID");

                    b.HasKey("PackageId");

                    b.HasIndex("ScaleId");

                    b.ToTable("Packages");

                    b.HasData(
                        new
                        {
                            PackageId = 1,
                            PackageType = "BOX 1",
                            ScaleId = 1
                        },
                        new
                        {
                            PackageId = 2,
                            PackageType = "BOX 3",
                            ScaleId = 2
                        },
                        new
                        {
                            PackageId = 3,
                            PackageType = "Bag 1",
                            ScaleId = 1
                        },
                        new
                        {
                            PackageId = 4,
                            PackageType = "Bag 2",
                            ScaleId = 5
                        },
                        new
                        {
                            PackageId = 5,
                            PackageType = "Small Bag 1",
                            ScaleId = 2
                        },
                        new
                        {
                            PackageId = 6,
                            PackageType = "Small Bag 2",
                            ScaleId = 3
                        },
                        new
                        {
                            PackageId = 7,
                            PackageType = "BOX 3",
                            ScaleId = 4
                        });
                });

            modelBuilder.Entity("DataBase.SupplyData.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ProductID")
                        .UseIdentityColumn();

                    b.Property<string>("ProductName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            ProductName = "Black peppercorns"
                        },
                        new
                        {
                            ProductId = 2,
                            ProductName = "Ground cinnamon"
                        },
                        new
                        {
                            ProductId = 3,
                            ProductName = "Chili powder"
                        },
                        new
                        {
                            ProductId = 4,
                            ProductName = "Hot-red-chili flakes"
                        },
                        new
                        {
                            ProductId = 5,
                            ProductName = "Cumin"
                        },
                        new
                        {
                            ProductId = 6,
                            ProductName = "Ground ginger"
                        },
                        new
                        {
                            ProductId = 7,
                            ProductName = "Spicy Paprika"
                        });
                });

            modelBuilder.Entity("DataBase.SupplyData.ProductStatus1", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("StatusID")
                        .UseIdentityColumn();

                    b.Property<int?>("LocationId")
                        .HasColumnType("int")
                        .HasColumnName("LocationID");

                    b.Property<int?>("PackageId")
                        .HasColumnType("int")
                        .HasColumnName("PackageID");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("ProductID");

                    b.Property<int?>("UnitInstock")
                        .HasColumnType("int");

                    b.Property<int?>("UnitinOrder")
                        .HasColumnType("int");

                    b.HasKey("StatusId");

                    b.HasIndex("LocationId");

                    b.HasIndex("PackageId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductStatus1");

                    b.HasData(
                        new
                        {
                            StatusId = 1,
                            LocationId = 1,
                            PackageId = 3,
                            ProductId = 2,
                            UnitInstock = 10,
                            UnitinOrder = 30
                        },
                        new
                        {
                            StatusId = 2,
                            LocationId = 1,
                            PackageId = 1,
                            ProductId = 5,
                            UnitInstock = 15,
                            UnitinOrder = 30
                        },
                        new
                        {
                            StatusId = 3,
                            LocationId = 2,
                            PackageId = 3,
                            ProductId = 3,
                            UnitInstock = 20,
                            UnitinOrder = 25
                        },
                        new
                        {
                            StatusId = 4,
                            LocationId = 3,
                            PackageId = 4,
                            ProductId = 6,
                            UnitInstock = 15,
                            UnitinOrder = 16
                        },
                        new
                        {
                            StatusId = 5,
                            LocationId = 2,
                            PackageId = 1,
                            ProductId = 3,
                            UnitInstock = 15,
                            UnitinOrder = 30
                        },
                        new
                        {
                            StatusId = 6,
                            LocationId = 1,
                            PackageId = 1,
                            ProductId = 1,
                            UnitInstock = 10,
                            UnitinOrder = 15
                        });
                });

            modelBuilder.Entity("DataBase.SupplyData.ScaleValue", b =>
                {
                    b.Property<int>("ScaleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ScaleID")
                        .UseIdentityColumn();

                    b.Property<string>("ScalesTypes")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ScaleId");

                    b.ToTable("ScaleValue");

                    b.HasData(
                        new
                        {
                            ScaleId = 1,
                            ScalesTypes = "5 kg"
                        },
                        new
                        {
                            ScaleId = 2,
                            ScalesTypes = "10 kg"
                        },
                        new
                        {
                            ScaleId = 3,
                            ScalesTypes = "500 g"
                        },
                        new
                        {
                            ScaleId = 4,
                            ScalesTypes = "300 g"
                        },
                        new
                        {
                            ScaleId = 5,
                            ScalesTypes = "100 g"
                        });
                });

            modelBuilder.Entity("DataBase.SupplyData.User", b =>
                {
                    b.Property<int>("UsersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UsersID")
                        .UseIdentityColumn();

                    b.Property<bool>("Admin")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UsersId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UsersId = 1,
                            Admin = true,
                            Email = "admin@gmail.com",
                            Password = "Aa123456",
                            Username = "Admin"
                        },
                        new
                        {
                            UsersId = 2,
                            Admin = true,
                            Email = "User2@gmail.com",
                            Password = "Aa123456",
                            Username = "User1"
                        });
                });

            modelBuilder.Entity("DataBase.SupplyData.Package", b =>
                {
                    b.HasOne("DataBase.SupplyData.ScaleValue", "Scale")
                        .WithMany("Packages")
                        .HasForeignKey("ScaleId")
                        .HasConstraintName("FK_Packages_ScaleValue")
                        .IsRequired();

                    b.Navigation("Scale");
                });

            modelBuilder.Entity("DataBase.SupplyData.ProductStatus1", b =>
                {
                    b.HasOne("DataBase.SupplyData.Location", "Location")
                        .WithMany("ProductStatus1s")
                        .HasForeignKey("LocationId")
                        .HasConstraintName("FK_ProductStatus1_Locations");

                    b.HasOne("DataBase.SupplyData.Package", "Package")
                        .WithMany("ProductStatus1s")
                        .HasForeignKey("PackageId")
                        .HasConstraintName("FK_ProductStatus1_Packages");

                    b.HasOne("DataBase.SupplyData.Product", "Product")
                        .WithMany("ProductStatus1s")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_ProductStatus1_Products");

                    b.Navigation("Location");

                    b.Navigation("Package");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DataBase.SupplyData.Location", b =>
                {
                    b.Navigation("ProductStatus1s");
                });

            modelBuilder.Entity("DataBase.SupplyData.Package", b =>
                {
                    b.Navigation("ProductStatus1s");
                });

            modelBuilder.Entity("DataBase.SupplyData.Product", b =>
                {
                    b.Navigation("ProductStatus1s");
                });

            modelBuilder.Entity("DataBase.SupplyData.ScaleValue", b =>
                {
                    b.Navigation("Packages");
                });
#pragma warning restore 612, 618
        }
    }
}
