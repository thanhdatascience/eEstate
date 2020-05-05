using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eEstate.Migrations
{
    public partial class azuresql : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TouristAttractions",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostingDate",
                value: new DateTime(2020, 4, 7, 22, 46, 19, 274, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "TouristAttractions",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostingDate",
                value: new DateTime(2020, 4, 7, 22, 46, 19, 275, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "TouristAttractions",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostingDate",
                value: new DateTime(2020, 4, 7, 22, 46, 19, 275, DateTimeKind.Local).AddTicks(6334));

            migrationBuilder.UpdateData(
                table: "TouristAttractions",
                keyColumn: "Id",
                keyValue: 4,
                column: "PostingDate",
                value: new DateTime(2020, 4, 7, 22, 46, 19, 275, DateTimeKind.Local).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "TouristAttractions",
                keyColumn: "Id",
                keyValue: 5,
                column: "PostingDate",
                value: new DateTime(2020, 4, 7, 22, 46, 19, 275, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "TouristAttractions",
                keyColumn: "Id",
                keyValue: 6,
                column: "PostingDate",
                value: new DateTime(2020, 4, 7, 22, 46, 19, 275, DateTimeKind.Local).AddTicks(6350));
        }
    }
}
