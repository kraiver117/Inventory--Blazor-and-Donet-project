using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class FixingFieldInOutDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "36cb492d-69e4-4e96-abf8-b7e09d63e480");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "754c878e-8450-4274-87e3-e19224fbb03f");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "83cc98af-4ca4-4f7c-8d40-3498fdfa5260");

            migrationBuilder.DropColumn(
                name: "InOutDater",
                table: "InOuts");

            migrationBuilder.AddColumn<DateTime>(
                name: "InOutDate",
                table: "InOuts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "bbab3f32-846b-4ff1-b5ff-975f29aacb72", "Corregidora #48", "Bodega central" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "2099de3d-8e0b-4467-83db-5abf15014b75", "Zaragoza #35", "Bodega Norte" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "632d14d3-db0d-49fb-b695-9af78d9f9de4", "Amado Nervo #1203", "Bodega Oeste" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "2099de3d-8e0b-4467-83db-5abf15014b75");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "632d14d3-db0d-49fb-b695-9af78d9f9de4");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "bbab3f32-846b-4ff1-b5ff-975f29aacb72");

            migrationBuilder.DropColumn(
                name: "InOutDate",
                table: "InOuts");

            migrationBuilder.AddColumn<DateTime>(
                name: "InOutDater",
                table: "InOuts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "36cb492d-69e4-4e96-abf8-b7e09d63e480", "Corregidora #48", "Bodega central" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "754c878e-8450-4274-87e3-e19224fbb03f", "Zaragoza #35", "Bodega Norte" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "83cc98af-4ca4-4f7c-8d40-3498fdfa5260", "Amado Nervo #1203", "Bodega Oeste" });
        }
    }
}
