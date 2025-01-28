using System;
using CommunityApp_Lab3.Models;
using Microsoft.EntityFrameworkCore;

namespace CommunityApp_Lab3.Data;

public static class SeedData
{
    public static void Seed(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<Province>().HasData(GetProvinces());
        modelBuilder.Entity<City>().HasData(GetCities());
    }

    public static List<Province> GetProvinces() {
        List<Province> provinces = new List<Province>() {
            new Province() {
                ProvinceCode="BC",
                ProvinceName="British Columbia"
            },
            new Province() {
                ProvinceCode="PE",
                ProvinceName="Prince Edward Island"
            },
            new Province() {
                ProvinceCode="AB",
                ProvinceName="Alberta"
            }
        };

        return provinces;
    }

    public static List<City> GetCities() {
        List<City> cities = new List<City>() {
            new City() {
                CityId=1,
                CityName="Vancouver",
                Population=2708000,
                ProvinceCode="BC"
            },
            new City() {
                CityId=2,
                CityName="Burnaby",
                Population=274425,
                ProvinceCode="BC"
            },
            new City() {
                CityId=3,
                CityName="Surrey",
                Population=696175,
                ProvinceCode="BC"
            },
            //-------------------------------------------------
            new City() {
                CityId=4,
                CityName="Charlottetown",
                Population=36000,
                ProvinceCode="PE"
            },
            new City() {
                CityId=5,
                CityName="Summerside",
                Population=15000,
                ProvinceCode="PE"
            },
            new City() {
                CityId=6,
                CityName="Stratford",
                Population=10900,
                ProvinceCode="PE"
            },
            //-------------------------------------------------
            new City() {
                CityId=7,
                CityName="Calgary",
                Population=1306000,
                ProvinceCode="AB"
            },
            new City() {
                CityId=8,
                CityName="Edmonton",
                Population=1010000,
                ProvinceCode="PE"
            },
            new City() {
                CityId=9,
                CityName="Red Deer",
                Population=100000,
                ProvinceCode="PE"
            },
        };

        return cities;
    }
}
