using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eEstate.Migrations
{
    public partial class f : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TouristAttractions",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostingDate",
                value: new DateTime(2020, 4, 7, 22, 39, 47, 331, DateTimeKind.Local).AddTicks(1907));

            migrationBuilder.UpdateData(
                table: "TouristAttractions",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostingDate",
                value: new DateTime(2020, 4, 7, 22, 39, 47, 332, DateTimeKind.Local).AddTicks(1872));

            migrationBuilder.UpdateData(
                table: "TouristAttractions",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostingDate",
                value: new DateTime(2020, 4, 7, 22, 39, 47, 332, DateTimeKind.Local).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "TouristAttractions",
                keyColumn: "Id",
                keyValue: 4,
                column: "PostingDate",
                value: new DateTime(2020, 4, 7, 22, 39, 47, 332, DateTimeKind.Local).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "TouristAttractions",
                keyColumn: "Id",
                keyValue: 5,
                column: "PostingDate",
                value: new DateTime(2020, 4, 7, 22, 39, 47, 332, DateTimeKind.Local).AddTicks(1933));

            migrationBuilder.UpdateData(
                table: "TouristAttractions",
                keyColumn: "Id",
                keyValue: 6,
                column: "PostingDate",
                value: new DateTime(2020, 4, 7, 22, 39, 47, 332, DateTimeKind.Local).AddTicks(1937));
        }
    }
}
