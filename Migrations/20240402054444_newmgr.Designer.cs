﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Save__plan_your_trips.Data;

#nullable disable

namespace Save__plan_your_trips.Migrations
{
    [DbContext(typeof(ScheduleTripsDbContext))]
    [Migration("20240402054444_newmgr")]
    partial class newmgr
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Save__plan_your_trips.Models.Domain.Album", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Album");
                });

            modelBuilder.Entity("Save__plan_your_trips.Models.Domain.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AlbumId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Save__plan_your_trips.Models.Domain.Image", b =>
                {
                    b.HasOne("Save__plan_your_trips.Models.Domain.Album", "Album")
                        .WithMany("Images")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");
                });

            modelBuilder.Entity("Save__plan_your_trips.Models.Domain.Album", b =>
                {
                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
