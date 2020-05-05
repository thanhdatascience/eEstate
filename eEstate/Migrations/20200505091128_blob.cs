using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eEstate.Migrations
{
    public partial class blob : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TouristAttractions",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostingDate",
                value: new DateTime(2020, 5, 5, 16, 11, 28, 176, DateTimeKind.Local).AddTicks(1743));

            migrationBuilder.UpdateData(
                table: "TouristAttractions",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostingDate",
                value: new DateTime(2020, 5, 5, 16, 11, 28, 177, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "TouristAttractions",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostingDate",
                value: new DateTime(2020, 5, 5, 16, 11, 28, 177, DateTimeKind.Local).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "TouristAttractions",
                keyColumn: "Id",
                keyValue: 4,
                column: "PostingDate",
                value: new DateTime(2020, 5, 5, 16, 11, 28, 177, DateTimeKind.Local).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "TouristAttractions",
                keyColumn: "Id",
                keyValue: 5,
                column: "PostingDate",
                value: new DateTime(2020, 5, 5, 16, 11, 28, 177, DateTimeKind.Local).AddTicks(1391));

            migrationBuilder.UpdateData(
                table: "TouristAttractions",
                keyColumn: "Id",
                keyValue: 6,
                column: "PostingDate",
                value: new DateTime(2020, 5, 5, 16, 11, 28, 177, DateTimeKind.Local).AddTicks(1396));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TouristAttractions",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostingDate",
                value: new DateTime(2020, 5, 5, 15, 19, 6, 3, DateTimeKind.Local).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "TouristAttractions",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostingDate",
                value: new DateTime(2020, 5, 5, 15, 19, 6, 4, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "TouristAttractions",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostingDate",
                value: new DateTime(2020, 5, 5, 15, 19, 6, 4, DateTimeKind.Local).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "TouristAttractions",
                keyColumn: "Id",
                keyValue: 4,
                column: "PostingDate",
                value: new DateTime(2020, 5, 5, 15, 19, 6, 4, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "TouristAttractions",
                keyColumn: "Id",
                keyValue: 5,
                column: "PostingDate",
                value: new DateTime(2020, 5, 5, 15, 19, 6, 4, DateTimeKind.Local).AddTicks(4994));

            migrationBuilder.UpdateData(
                table: "TouristAttractions",
                keyColumn: "Id",
                keyValue: 6,
                column: "PostingDate",
                value: new DateTime(2020, 5, 5, 15, 19, 6, 4, DateTimeKind.Local).AddTicks(4998));
        }
    }
}
