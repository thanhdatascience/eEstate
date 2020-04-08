using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eEstate.Migrations
{
    public partial class e : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhotoPath",
                table: "TouristAttractions",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoPath",
                table: "TouristAttractions");

            migrationBuilder.UpdateData(
                table: "TouristAttractions",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostingDate",
                value: new DateTime(2020, 4, 7, 21, 43, 16, 631, DateTimeKind.Local).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "TouristAttractions",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostingDate",
                value: new DateTime(2020, 4, 7, 21, 43, 16, 632, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "TouristAttractions",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostingDate",
                value: new DateTime(2020, 4, 7, 21, 43, 16, 632, DateTimeKind.Local).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "TouristAttractions",
                keyColumn: "Id",
                keyValue: 4,
                column: "PostingDate",
                value: new DateTime(2020, 4, 7, 21, 43, 16, 632, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "TouristAttractions",
                keyColumn: "Id",
                keyValue: 5,
                column: "PostingDate",
                value: new DateTime(2020, 4, 7, 21, 43, 16, 632, DateTimeKind.Local).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "TouristAttractions",
                keyColumn: "Id",
                keyValue: 6,
                column: "PostingDate",
                value: new DateTime(2020, 4, 7, 21, 43, 16, 632, DateTimeKind.Local).AddTicks(2122));
        }
    }
}
