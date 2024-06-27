﻿// <auto-generated />
using System;
using BirdAPI.ApiService.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BirdAPI.ApiService.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("BirdAPI.ApiService.Database.Models.Label", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("RecordingId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RecordingId");

                    b.ToTable("Label");
                });

            modelBuilder.Entity("BirdAPI.ApiService.Database.Models.Osci", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("XenoCantoEntryid")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("large")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("med")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("small")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("XenoCantoEntryid")
                        .IsUnique();

                    b.ToTable("Oscis");
                });

            modelBuilder.Entity("BirdAPI.ApiService.Database.Models.Recording", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Duration")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Recordings");
                });

            modelBuilder.Entity("BirdAPI.ApiService.Database.Models.Sono", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("XenoCantoEntryid")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("full")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("large")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("med")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("small")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("XenoCantoEntryid")
                        .IsUnique();

                    b.ToTable("Sonos");
                });

            modelBuilder.Entity("BirdAPI.ApiService.Database.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BirdAPI.ApiService.Database.Models.XenoCantoEntry", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("TEXT");

                    b.Property<string>("also")
                        .HasColumnType("TEXT");

                    b.Property<string>("alt")
                        .HasColumnType("TEXT");

                    b.Property<string>("animalSeen")
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "animal-seen");

                    b.Property<string>("auto")
                        .HasColumnType("TEXT");

                    b.Property<string>("birdSeen")
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "bird-seen");

                    b.Property<string>("cnt")
                        .HasColumnType("TEXT");

                    b.Property<string>("date")
                        .HasColumnType("TEXT");

                    b.Property<string>("dvc")
                        .HasColumnType("TEXT");

                    b.Property<string>("en")
                        .HasColumnType("TEXT");

                    b.Property<string>("file")
                        .HasColumnType("TEXT");

                    b.Property<string>("fileName")
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "file-name");

                    b.Property<string>("gen")
                        .HasColumnType("TEXT");

                    b.Property<string>("group")
                        .HasColumnType("TEXT");

                    b.Property<string>("lat")
                        .HasColumnType("TEXT");

                    b.Property<string>("length")
                        .HasColumnType("TEXT");

                    b.Property<string>("lic")
                        .HasColumnType("TEXT");

                    b.Property<string>("lng")
                        .HasColumnType("TEXT");

                    b.Property<string>("loc")
                        .HasColumnType("TEXT");

                    b.Property<string>("method")
                        .HasColumnType("TEXT");

                    b.Property<string>("mic")
                        .HasColumnType("TEXT");

                    b.Property<string>("playbackUsed")
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "playback-used");

                    b.Property<string>("q")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("rec")
                        .HasColumnType("TEXT");

                    b.Property<string>("regnr")
                        .HasColumnType("TEXT");

                    b.Property<string>("rmk")
                        .HasColumnType("TEXT");

                    b.Property<string>("sex")
                        .HasColumnType("TEXT");

                    b.Property<string>("smp")
                        .HasColumnType("TEXT");

                    b.Property<string>("sp")
                        .HasColumnType("TEXT");

                    b.Property<string>("ssp")
                        .HasColumnType("TEXT");

                    b.Property<string>("stage")
                        .HasColumnType("TEXT");

                    b.Property<string>("temp")
                        .HasColumnType("TEXT");

                    b.Property<string>("time")
                        .HasColumnType("TEXT");

                    b.Property<string>("type")
                        .HasColumnType("TEXT");

                    b.Property<string>("uploaded")
                        .HasColumnType("TEXT");

                    b.Property<string>("url")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("XenoCantoEntries");
                });

            modelBuilder.Entity("BirdAPI.ApiService.Database.Models.Label", b =>
                {
                    b.HasOne("BirdAPI.ApiService.Database.Models.Recording", "Recording")
                        .WithMany("Labels")
                        .HasForeignKey("RecordingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recording");
                });

            modelBuilder.Entity("BirdAPI.ApiService.Database.Models.Osci", b =>
                {
                    b.HasOne("BirdAPI.ApiService.Database.Models.XenoCantoEntry", "XenoCantoEntry")
                        .WithOne("osci")
                        .HasForeignKey("BirdAPI.ApiService.Database.Models.Osci", "XenoCantoEntryid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("XenoCantoEntry");
                });

            modelBuilder.Entity("BirdAPI.ApiService.Database.Models.Sono", b =>
                {
                    b.HasOne("BirdAPI.ApiService.Database.Models.XenoCantoEntry", "XenoCantoEntry")
                        .WithOne("sono")
                        .HasForeignKey("BirdAPI.ApiService.Database.Models.Sono", "XenoCantoEntryid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("XenoCantoEntry");
                });

            modelBuilder.Entity("BirdAPI.ApiService.Database.Models.Recording", b =>
                {
                    b.Navigation("Labels");
                });

            modelBuilder.Entity("BirdAPI.ApiService.Database.Models.XenoCantoEntry", b =>
                {
                    b.Navigation("osci");

                    b.Navigation("sono");
                });
#pragma warning restore 612, 618
        }
    }
}
