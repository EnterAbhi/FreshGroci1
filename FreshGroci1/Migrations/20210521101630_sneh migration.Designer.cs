// <auto-generated />
using System;
using FreshGroci1.DataBaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FreshGroci1.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    [Migration("20210521101630_sneh migration")]
    partial class snehmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FreshGroci1.Models.CartModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ProductsId")
                        .HasColumnType("int");

                    b.Property<int>("cartQuantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductsId");

                    b.ToTable("tbl_Cart");
                });

            modelBuilder.Entity("FreshGroci1.Models.ProductModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("price")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tbl_Product");
                });

            modelBuilder.Entity("FreshGroci1.Models.CartModel", b =>
                {
                    b.HasOne("FreshGroci1.Models.ProductModel", "Products")
                        .WithMany()
                        .HasForeignKey("ProductsId");

                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
