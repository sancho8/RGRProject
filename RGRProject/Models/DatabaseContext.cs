using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RGRProject.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        public DatabaseContext() : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var appSettingsJson = AppSettingsHelper.GetAppSettings();
                var connectionString = appSettingsJson["ConnectionStrings:DefaultConnection"];
                optionsBuilder.UseNpgsql(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region PlaceSeed
            modelBuilder.Entity<Place>().HasData(
                new Place() { ID = 1, Lattitude = 50.4316, Longitude = 30.516, Address = "проспект Перемоги, 45, Київ, 03057", Name = "Mister Cat", Description = "Поздний ужин, хорошая коктейльная карта", Facilities = new string[] { "Wifi", "Доставка" }, Status = 1, Rating = 4, Site = "https://mistercat.com.ua/", Phone = "044 578 1690", Images = new string[] { "https://www.google.com/url?sa=i&source=images&cd=&cad=rja&uact=8&ved=2ahUKEwiCjJHour3fAhUwz4UKHaSGBTgQjRx6BAgBEAU&url=https%3A%2F%2Fmistercat.com.ua%2F&psig=AOvVaw3LwcdGYqDLFeqkFC_275Bn&ust=1545912455470417" } },
                new Place() { ID = 2, Lattitude = 50.432, Longitude = 30.5155, Address = "проспект Перемоги, 45, Київ, 03057", Name = "Mister Cat", Description = "Поздний ужин, хорошая коктейльная карта", Facilities = new string[] { "Wifi", "Доставка" }, Status = 1, Rating = 4, Site = "https://mistercat.com.ua/", Phone = "044 578 1690", Images = new string[] { "https://www.google.com/url?sa=i&source=images&cd=&cad=rja&uact=8&ved=2ahUKEwiCjJHour3fAhUwz4UKHaSGBTgQjRx6BAgBEAU&url=https%3A%2F%2Fmistercat.com.ua%2F&psig=AOvVaw3LwcdGYqDLFeqkFC_275Bn&ust=1545912455470417" } },
                new Place() { ID = 3, Lattitude = 50.431282, Longitude = 30.51632, Address = "проспект Перемоги, 45, Київ, 03057", Name = "Mister Cat", Description = "Поздний ужин, хорошая коктейльная карта", Facilities = new string[] { "Wifi", "Доставка" }, Status = 1, Rating = 4, Site = "https://mistercat.com.ua/", Phone = "044 578 1690", Images = new string[] { "https://www.google.com/url?sa=i&source=images&cd=&cad=rja&uact=8&ved=2ahUKEwiCjJHour3fAhUwz4UKHaSGBTgQjRx6BAgBEAU&url=https%3A%2F%2Fmistercat.com.ua%2F&psig=AOvVaw3LwcdGYqDLFeqkFC_275Bn&ust=1545912455470417" } },
                new Place() { ID = 4, Lattitude = 50.43134, Longitude = 30.51623, Address = "проспект Перемоги, 45, Київ, 03057", Name = "Mister Cat", Description = "Поздний ужин, хорошая коктейльная карта", Facilities = new string[] { "Wifi", "Доставка" }, Status = 1, Rating = 4, Site = "https://mistercat.com.ua/", Phone = "044 578 1690", Images = new string[] { "https://www.google.com/url?sa=i&source=images&cd=&cad=rja&uact=8&ved=2ahUKEwiCjJHour3fAhUwz4UKHaSGBTgQjRx6BAgBEAU&url=https%3A%2F%2Fmistercat.com.ua%2F&psig=AOvVaw3LwcdGYqDLFeqkFC_275Bn&ust=1545912455470417" } },
                new Place() { ID = 5, Lattitude = 50.431, Longitude = 30.51612, Address = "проспект Перемоги, 45, Київ, 03057", Name = "Mister Cat", Description = "Поздний ужин, хорошая коктейльная карта", Facilities = new string[] { "Wifi", "Доставка" }, Status = 1, Rating = 4, Site = "https://mistercat.com.ua/", Phone = "044 578 1690", Images = new string[] { "https://www.google.com/url?sa=i&source=images&cd=&cad=rja&uact=8&ved=2ahUKEwiCjJHour3fAhUwz4UKHaSGBTgQjRx6BAgBEAU&url=https%3A%2F%2Fmistercat.com.ua%2F&psig=AOvVaw3LwcdGYqDLFeqkFC_275Bn&ust=1545912455470417" } }
            );
            #endregion

            #region BookingSeed
            modelBuilder.Entity<Booking>().HasData(
                new Booking() { ID = 1, CustomerName = "Іванов Іван", PlaceId = 1, CustomerContact = "0503234343", Rating = 4, Status = 2, BookingStart = new DateTime(2018, 12, 25, 16, 30, 00), BookingFinish = new DateTime(2018, 12, 25, 17, 30, 00) },
                new Booking() { ID = 2, CustomerName = "Іванов Іван", PlaceId = 2, CustomerContact = "0503234345", Rating = 5, Status = 2, BookingStart = new DateTime(2018, 12, 26, 16, 30, 00), BookingFinish = new DateTime(2018, 12, 26, 18, 00, 00) },
                new Booking() { ID = 3, CustomerName = "Петров Петро", PlaceId = 1, CustomerContact = "0503234341", Rating = null, Status = 1, BookingStart = new DateTime(2018, 12, 27, 16, 30, 00), BookingFinish = null }
            );
            #endregion
        }

        public DbSet<Place> Places { get; set; }
        public DbSet<Booking> Bookings { get; set; }

    }
}
