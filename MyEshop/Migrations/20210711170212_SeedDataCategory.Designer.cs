// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyEshop.Data;

namespace MyEshop.Migrations
{
    [DbContext(typeof(MyEshopContext))]
    [Migration("20210711170212_SeedDataCategory")]
    partial class SeedDataCategory
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyEshop.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "لباس زنانه",
                            Name = "لباس زنانه"
                        },
                        new
                        {
                            Id = 2,
                            Description = "لباس مردانه",
                            Name = "لباس مردانه"
                        },
                        new
                        {
                            Id = 3,
                            Description = "لباس پسرانه",
                            Name = "لباس پسرانه"
                        },
                        new
                        {
                            Id = 4,
                            Description = "لباس دخترانه",
                            Name = "لباس دخترانه"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
