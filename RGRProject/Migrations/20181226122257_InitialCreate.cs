using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace RGRProject.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    PlaceID = table.Column<int>(nullable: false),
                    CustomerName = table.Column<string>(nullable: true),
                    CustomerContact = table.Column<string>(nullable: true),
                    BookingStart = table.Column<DateTime>(nullable: true),
                    BookingFinish = table.Column<DateTime>(nullable: true),
                    Rating = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Places",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Lattitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    Images = table.Column<string[]>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Facilities = table.Column<string[]>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Site = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Places", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "ID", "BookingFinish", "BookingStart", "CustomerContact", "CustomerName", "PlaceID", "Rating", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 12, 25, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 25, 16, 30, 0, 0, DateTimeKind.Unspecified), "0503234343", "Іванов Іван", 1, 4, 2 },
                    { 2, new DateTime(2018, 12, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 26, 16, 30, 0, 0, DateTimeKind.Unspecified), "0503234345", "Іванов Іван", 2, 5, 2 },
                    { 3, null, new DateTime(2018, 12, 27, 16, 30, 0, 0, DateTimeKind.Unspecified), "0503234341", "Петров Петро", 1, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "ID", "Address", "Description", "Facilities", "Images", "Lattitude", "Longitude", "Name", "Phone", "Rating", "Site", "Status" },
                values: new object[,]
                {
                    { 1, "проспект Перемоги, 45, Київ, 03057", "Поздний ужин, хорошая коктейльная карта", new[] { "Wifi", "Доставка" }, new[] { "https://www.google.com/url?sa=i&source=images&cd=&cad=rja&uact=8&ved=2ahUKEwiCjJHour3fAhUwz4UKHaSGBTgQjRx6BAgBEAU&url=https%3A%2F%2Fmistercat.com.ua%2F&psig=AOvVaw3LwcdGYqDLFeqkFC_275Bn&ust=1545912455470417" }, 50.4316, 30.516, "Mister Cat", "044 578 1690", 4, "https://mistercat.com.ua/", 1 },
                    { 2, "проспект Перемоги, 45, Київ, 03057", "Поздний ужин, хорошая коктейльная карта", new[] { "Wifi", "Доставка" }, new[] { "https://www.google.com/url?sa=i&source=images&cd=&cad=rja&uact=8&ved=2ahUKEwiCjJHour3fAhUwz4UKHaSGBTgQjRx6BAgBEAU&url=https%3A%2F%2Fmistercat.com.ua%2F&psig=AOvVaw3LwcdGYqDLFeqkFC_275Bn&ust=1545912455470417" }, 50.432, 30.5155, "Mister Cat", "044 578 1690", 4, "https://mistercat.com.ua/", 1 },
                    { 3, "проспект Перемоги, 45, Київ, 03057", "Поздний ужин, хорошая коктейльная карта", new[] { "Wifi", "Доставка" }, new[] { "https://www.google.com/url?sa=i&source=images&cd=&cad=rja&uact=8&ved=2ahUKEwiCjJHour3fAhUwz4UKHaSGBTgQjRx6BAgBEAU&url=https%3A%2F%2Fmistercat.com.ua%2F&psig=AOvVaw3LwcdGYqDLFeqkFC_275Bn&ust=1545912455470417" }, 50.431282, 30.51632, "Mister Cat", "044 578 1690", 4, "https://mistercat.com.ua/", 1 },
                    { 4, "проспект Перемоги, 45, Київ, 03057", "Поздний ужин, хорошая коктейльная карта", new[] { "Wifi", "Доставка" }, new[] { "https://www.google.com/url?sa=i&source=images&cd=&cad=rja&uact=8&ved=2ahUKEwiCjJHour3fAhUwz4UKHaSGBTgQjRx6BAgBEAU&url=https%3A%2F%2Fmistercat.com.ua%2F&psig=AOvVaw3LwcdGYqDLFeqkFC_275Bn&ust=1545912455470417" }, 50.43134, 30.51623, "Mister Cat", "044 578 1690", 4, "https://mistercat.com.ua/", 1 },
                    { 5, "проспект Перемоги, 45, Київ, 03057", "Поздний ужин, хорошая коктейльная карта", new[] { "Wifi", "Доставка" }, new[] { "https://www.google.com/url?sa=i&source=images&cd=&cad=rja&uact=8&ved=2ahUKEwiCjJHour3fAhUwz4UKHaSGBTgQjRx6BAgBEAU&url=https%3A%2F%2Fmistercat.com.ua%2F&psig=AOvVaw3LwcdGYqDLFeqkFC_275Bn&ust=1545912455470417" }, 50.431, 30.51612, "Mister Cat", "044 578 1690", 4, "https://mistercat.com.ua/", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Places");
        }
    }
}
