﻿// <auto-generated />
using CompareMotos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CompareMotos.Migrations
{
    [DbContext(typeof(CompareMotosContext))]
    [Migration("20190713175627_updatesimple2")]
    partial class updatesimple2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CompareMotos.Models.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("BrandId");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("CompareMotos.Models.Displacement", b =>
                {
                    b.Property<int>("DisplacementId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Name");

                    b.HasKey("DisplacementId");

                    b.ToTable("Displacement");
                });

            modelBuilder.Entity("CompareMotos.Models.ModelMotorcycle", b =>
                {
                    b.Property<int>("ModelMotorcycleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ModelMotorcycleId");

                    b.ToTable("ModelMotorcycle");
                });

            modelBuilder.Entity("CompareMotos.Models.Motorcycle", b =>
                {
                    b.Property<int>("MotorcycleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId");

                    b.Property<int>("DisplacementId");

                    b.Property<double>("Height");

                    b.Property<double>("Length");

                    b.Property<int>("ModelMotorcycleId");

                    b.Property<double>("Price");

                    b.Property<int>("TypeMotorcycleId");

                    b.Property<double>("Weight");

                    b.Property<double>("Width");

                    b.Property<int>("Year");

                    b.HasKey("MotorcycleId");

                    b.HasIndex("BrandId");

                    b.HasIndex("DisplacementId");

                    b.HasIndex("ModelMotorcycleId");

                    b.HasIndex("TypeMotorcycleId");

                    b.ToTable("Motorcycle");
                });

            modelBuilder.Entity("CompareMotos.Models.TypeMotorcycle", b =>
                {
                    b.Property<int>("TypeMotorcycleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("TypeMotorcycleId");

                    b.ToTable("TypeMotorcycle");
                });

            modelBuilder.Entity("CompareMotos.Models.Motorcycle", b =>
                {
                    b.HasOne("CompareMotos.Models.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CompareMotos.Models.Displacement", "Displacement")
                        .WithMany()
                        .HasForeignKey("DisplacementId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CompareMotos.Models.ModelMotorcycle", "ModelMotorcycle")
                        .WithMany()
                        .HasForeignKey("ModelMotorcycleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CompareMotos.Models.TypeMotorcycle", "TypeMotorcycle")
                        .WithMany()
                        .HasForeignKey("TypeMotorcycleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
