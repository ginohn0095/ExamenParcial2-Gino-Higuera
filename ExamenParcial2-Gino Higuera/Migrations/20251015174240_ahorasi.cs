using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamenParcial2_Gino_Higuera.Migrations
{
    /// <inheritdoc />
    public partial class ahorasi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 10, 16, 11, 42, 40, 767, DateTimeKind.Local).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2025, 10, 17, 11, 42, 40, 767, DateTimeKind.Local).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2025, 10, 18, 11, 42, 40, 767, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2025, 10, 19, 11, 42, 40, 767, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2025, 10, 20, 11, 42, 40, 767, DateTimeKind.Local).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2025, 10, 21, 11, 42, 40, 767, DateTimeKind.Local).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2025, 10, 22, 11, 42, 40, 767, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2025, 10, 23, 11, 42, 40, 767, DateTimeKind.Local).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2025, 10, 24, 11, 42, 40, 767, DateTimeKind.Local).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2025, 10, 25, 11, 42, 40, 767, DateTimeKind.Local).AddTicks(5138));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 10, 16, 11, 40, 38, 460, DateTimeKind.Local).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2025, 10, 17, 11, 40, 38, 460, DateTimeKind.Local).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2025, 10, 18, 11, 40, 38, 460, DateTimeKind.Local).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2025, 10, 19, 11, 40, 38, 460, DateTimeKind.Local).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2025, 10, 20, 11, 40, 38, 460, DateTimeKind.Local).AddTicks(2005));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2025, 10, 21, 11, 40, 38, 460, DateTimeKind.Local).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2025, 10, 22, 11, 40, 38, 460, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2025, 10, 23, 11, 40, 38, 460, DateTimeKind.Local).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2025, 10, 24, 11, 40, 38, 460, DateTimeKind.Local).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2025, 10, 25, 11, 40, 38, 460, DateTimeKind.Local).AddTicks(2011));
        }
    }
}
