﻿// <auto-generated />
using CommunityApp_Lab3.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CommunityApp_Lab3.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.1");

            modelBuilder.Entity("CommunityApp_Lab3.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CityName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Population")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProvinceCode")
                        .HasColumnType("TEXT");

                    b.HasKey("CityId");

                    b.HasIndex("ProvinceCode");

                    b.ToTable("City", (string)null);

                    b.HasData(
                        new
                        {
                            CityId = 1,
                            CityName = "Vancouver",
                            Population = 2708000,
                            ProvinceCode = "BC"
                        },
                        new
                        {
                            CityId = 2,
                            CityName = "Burnaby",
                            Population = 274425,
                            ProvinceCode = "BC"
                        },
                        new
                        {
                            CityId = 3,
                            CityName = "Surrey",
                            Population = 696175,
                            ProvinceCode = "BC"
                        },
                        new
                        {
                            CityId = 4,
                            CityName = "Charlottetown",
                            Population = 36000,
                            ProvinceCode = "PE"
                        },
                        new
                        {
                            CityId = 5,
                            CityName = "Summerside",
                            Population = 15000,
                            ProvinceCode = "PE"
                        },
                        new
                        {
                            CityId = 6,
                            CityName = "Stratford",
                            Population = 10900,
                            ProvinceCode = "PE"
                        },
                        new
                        {
                            CityId = 7,
                            CityName = "Calgary",
                            Population = 1306000,
                            ProvinceCode = "AB"
                        },
                        new
                        {
                            CityId = 8,
                            CityName = "Edmonton",
                            Population = 1010000,
                            ProvinceCode = "PE"
                        },
                        new
                        {
                            CityId = 9,
                            CityName = "Red Deer",
                            Population = 100000,
                            ProvinceCode = "PE"
                        });
                });

            modelBuilder.Entity("CommunityApp_Lab3.Models.Province", b =>
                {
                    b.Property<string>("ProvinceCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProvinceName")
                        .HasColumnType("TEXT");

                    b.HasKey("ProvinceCode");

                    b.ToTable("Province", (string)null);

                    b.HasData(
                        new
                        {
                            ProvinceCode = "BC",
                            ProvinceName = "British Columbia"
                        },
                        new
                        {
                            ProvinceCode = "PE",
                            ProvinceName = "Prince Edward Island"
                        },
                        new
                        {
                            ProvinceCode = "AB",
                            ProvinceName = "Alberta"
                        });
                });

            modelBuilder.Entity("CommunityApp_Lab3.Models.City", b =>
                {
                    b.HasOne("CommunityApp_Lab3.Models.Province", "Province")
                        .WithMany("Cities")
                        .HasForeignKey("ProvinceCode");

                    b.Navigation("Province");
                });

            modelBuilder.Entity("CommunityApp_Lab3.Models.Province", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
