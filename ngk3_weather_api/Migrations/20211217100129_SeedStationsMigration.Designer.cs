﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ngk3_weather_api.Models;

namespace ngk3_weather_api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211217100129_SeedStationsMigration")]
    partial class SeedStationsMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("ngk3_weather_api.Models.WeatherObservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<long>("Humidity")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Pressure")
                        .HasColumnType("decimal(4,1)");

                    b.Property<decimal>("Temperature")
                        .HasColumnType("decimal(3,1)");

                    b.Property<int>("WeatherStationId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("WeatherStationId");

                    b.ToTable("WeatherObservations");
                });

            modelBuilder.Entity("ngk3_weather_api.Models.WeatherStation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Latitude")
                        .HasColumnType("REAL");

                    b.Property<double>("Longitude")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("WeatherStations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Latitude = 56.234153999999997,
                            Longitude = 10.238569999999999,
                            Name = "Lystrup",
                            Password = "$2a$11$XjVT7tArgpNvBI93iIPpGuRHA03v1BQ7VObLETvIcwla8C54OuQP2",
                            Username = "lystrup1"
                        },
                        new
                        {
                            Id = 2,
                            Latitude = 45.572113999999999,
                            Longitude = 6.8293480000000004,
                            Name = "Les Arcs",
                            Password = "$2a$11$tTIcnjGW/6SDxlS8TrOvdeqwRHxDPLXSShyH73YhSZfU.OSPLjA.O",
                            Username = "lesarcs1"
                        },
                        new
                        {
                            Id = 3,
                            Latitude = -53.093660999999997,
                            Longitude = 73.527350999999996,
                            Name = "Heard Island & McDonald Islands",
                            Password = "$2a$11$bZvszlwPLe7bLQwcUB7W/u7K3SvsqA8wKQikyWxv1dYXnXwZflkfm",
                            Username = "mcd1"
                        });
                });

            modelBuilder.Entity("ngk3_weather_api.Models.WeatherObservation", b =>
                {
                    b.HasOne("ngk3_weather_api.Models.WeatherStation", "WeatherStation")
                        .WithMany("WeatherObservations")
                        .HasForeignKey("WeatherStationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WeatherStation");
                });

            modelBuilder.Entity("ngk3_weather_api.Models.WeatherStation", b =>
                {
                    b.Navigation("WeatherObservations");
                });
#pragma warning restore 612, 618
        }
    }
}