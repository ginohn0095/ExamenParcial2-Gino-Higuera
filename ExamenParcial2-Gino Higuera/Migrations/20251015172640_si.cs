using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamenParcial2_Gino_Higuera.Migrations
{
    /// <inheritdoc />
    public partial class si : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 10, 16, 11, 26, 39, 869, DateTimeKind.Local).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2025, 10, 17, 11, 26, 39, 869, DateTimeKind.Local).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2025, 10, 18, 11, 26, 39, 869, DateTimeKind.Local).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2025, 10, 19, 11, 26, 39, 869, DateTimeKind.Local).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2025, 10, 20, 11, 26, 39, 869, DateTimeKind.Local).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2025, 10, 21, 11, 26, 39, 869, DateTimeKind.Local).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2025, 10, 22, 11, 26, 39, 869, DateTimeKind.Local).AddTicks(1903));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2025, 10, 23, 11, 26, 39, 869, DateTimeKind.Local).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2025, 10, 24, 11, 26, 39, 869, DateTimeKind.Local).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2025, 10, 25, 11, 26, 39, 869, DateTimeKind.Local).AddTicks(1907));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 10, 16, 10, 56, 44, 313, DateTimeKind.Local).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2025, 10, 17, 10, 56, 44, 313, DateTimeKind.Local).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2025, 10, 18, 10, 56, 44, 313, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2025, 10, 19, 10, 56, 44, 313, DateTimeKind.Local).AddTicks(622));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2025, 10, 20, 10, 56, 44, 313, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2025, 10, 21, 10, 56, 44, 313, DateTimeKind.Local).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2025, 10, 22, 10, 56, 44, 313, DateTimeKind.Local).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2025, 10, 23, 10, 56, 44, 313, DateTimeKind.Local).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2025, 10, 24, 10, 56, 44, 313, DateTimeKind.Local).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2025, 10, 25, 10, 56, 44, 313, DateTimeKind.Local).AddTicks(636));
        }
    }
}
