using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVillaVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VillaID",
                table: "VillasNumber",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 14, 57, 8, 927, DateTimeKind.Local).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 14, 57, 8, 928, DateTimeKind.Local).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 14, 57, 8, 928, DateTimeKind.Local).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 14, 57, 8, 928, DateTimeKind.Local).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 14, 57, 8, 928, DateTimeKind.Local).AddTicks(14));

            migrationBuilder.CreateIndex(
                name: "IX_VillasNumber_VillaID",
                table: "VillasNumber",
                column: "VillaID");

            migrationBuilder.AddForeignKey(
                name: "FK_VillasNumber_Villas_VillaID",
                table: "VillasNumber",
                column: "VillaID",
                principalTable: "Villas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VillasNumber_Villas_VillaID",
                table: "VillasNumber");

            migrationBuilder.DropIndex(
                name: "IX_VillasNumber_VillaID",
                table: "VillasNumber");

            migrationBuilder.DropColumn(
                name: "VillaID",
                table: "VillasNumber");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 12, 24, 11, 532, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 12, 24, 11, 532, DateTimeKind.Local).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 12, 24, 11, 532, DateTimeKind.Local).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 12, 24, 11, 532, DateTimeKind.Local).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 12, 24, 11, 532, DateTimeKind.Local).AddTicks(6774));
        }
    }
}
