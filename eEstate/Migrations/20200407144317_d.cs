using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eEstate.Migrations
{
    public partial class d : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Area",
                table: "TouristAttractions",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Direction",
                table: "TouristAttractions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Juridical",
                table: "TouristAttractions",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PostingDate",
                table: "TouristAttractions",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "TouristAttractions",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "TouristAttractions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Area", "Direction", "Juridical", "PostingDate", "Price" },
                values: new object[] { 100m, "In front of the door", "Ruled", new DateTime(2020, 4, 7, 21, 43, 16, 631, DateTimeKind.Local).AddTicks(2491), 10m });

            migrationBuilder.UpdateData(
                table: "TouristAttractions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Area", "Direction", "Juridical", "PostingDate", "Price" },
                values: new object[] { 100m, "In front of the door", "Ruled", new DateTime(2020, 4, 7, 21, 43, 16, 632, DateTimeKind.Local).AddTicks(2063), 10m });

            migrationBuilder.UpdateData(
                table: "TouristAttractions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Area", "Direction", "Juridical", "PostingDate", "Price" },
                values: new object[] { 100m, "In front of the door", "Ruled", new DateTime(2020, 4, 7, 21, 43, 16, 632, DateTimeKind.Local).AddTicks(2107), 10m });

            migrationBuilder.UpdateData(
                table: "TouristAttractions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Area", "Direction", "Juridical", "PostingDate", "Price" },
                values: new object[] { 100m, "In front of the door", "Ruled", new DateTime(2020, 4, 7, 21, 43, 16, 632, DateTimeKind.Local).AddTicks(2114), 10m });

            migrationBuilder.UpdateData(
                table: "TouristAttractions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Area", "Direction", "Juridical", "PostingDate", "Price" },
                values: new object[] { 100m, "In front of the door", "Ruled", new DateTime(2020, 4, 7, 21, 43, 16, 632, DateTimeKind.Local).AddTicks(2117), 10m });

            migrationBuilder.UpdateData(
                table: "TouristAttractions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Area", "Direction", "Juridical", "PostingDate", "Price" },
                values: new object[] { 100m, "In front of the door", "Ruled", new DateTime(2020, 4, 7, 21, 43, 16, 632, DateTimeKind.Local).AddTicks(2122), 10m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Area",
                table: "TouristAttractions");

            migrationBuilder.DropColumn(
                name: "Direction",
                table: "TouristAttractions");

            migrationBuilder.DropColumn(
                name: "Juridical",
                table: "TouristAttractions");

            migrationBuilder.DropColumn(
                name: "PostingDate",
                table: "TouristAttractions");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "TouristAttractions");
        }
    }
}
