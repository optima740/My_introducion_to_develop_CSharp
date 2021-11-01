﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Space.DataAccessLayer;

namespace Space.Migrations
{
    [DbContext(typeof(SpaceObjectContext))]
    partial class SpaceObjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("Space.Models.SpaceObject", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<float>("Diametr")
                        .HasColumnType("REAL");

                    b.Property<float>("DistToSun")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("TypeObj")
                        .HasColumnType("TEXT");

                    b.Property<float>("Weight")
                        .HasColumnType("REAL");

                    b.HasKey("id");

                    b.ToTable("SpaceObjects");
                });

            modelBuilder.Entity("Space.Models.Asteroid", b =>
                {
                    b.HasBaseType("Space.Models.SpaceObject");

                    b.Property<float>("Speed")
                        .HasColumnType("REAL");

                    b.ToTable("Asteroids");
                });

            modelBuilder.Entity("Space.Models.BlackHole", b =>
                {
                    b.HasBaseType("Space.Models.SpaceObject");

                    b.Property<float>("Density")
                        .HasColumnType("REAL");

                    b.ToTable("BlackHole");
                });

            modelBuilder.Entity("Space.Models.Planet", b =>
                {
                    b.HasBaseType("Space.Models.SpaceObject");

                    b.Property<float>("TiltAngle")
                        .HasColumnType("REAL");

                    b.ToTable("Planets");
                });

            modelBuilder.Entity("Space.Models.Star", b =>
                {
                    b.HasBaseType("Space.Models.SpaceObject");

                    b.Property<float>("DegOfIllumination")
                        .HasColumnType("REAL");

                    b.ToTable("Stars");
                });

            modelBuilder.Entity("Space.Models.Asteroid", b =>
                {
                    b.HasOne("Space.Models.SpaceObject", null)
                        .WithOne()
                        .HasForeignKey("Space.Models.Asteroid", "id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Space.Models.BlackHole", b =>
                {
                    b.HasOne("Space.Models.SpaceObject", null)
                        .WithOne()
                        .HasForeignKey("Space.Models.BlackHole", "id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Space.Models.Planet", b =>
                {
                    b.HasOne("Space.Models.SpaceObject", null)
                        .WithOne()
                        .HasForeignKey("Space.Models.Planet", "id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Space.Models.Star", b =>
                {
                    b.HasOne("Space.Models.SpaceObject", null)
                        .WithOne()
                        .HasForeignKey("Space.Models.Star", "id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
