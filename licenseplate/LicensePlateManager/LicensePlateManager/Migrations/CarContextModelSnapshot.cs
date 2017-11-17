using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using LicensePlateManager.Entities;

namespace LicensePlateManager.Migrations
{
    [DbContext(typeof(CarContext))]
    partial class CarContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LicensePlateManager.Models.Car", b =>
                {
                    b.Property<string>("plate")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("car_brand");

                    b.Property<string>("car_model");

                    b.Property<string>("color");

                    b.Property<string>("year");

                    b.HasKey("plate");

                    b.ToTable("Cars");
                });
        }
    }
}
