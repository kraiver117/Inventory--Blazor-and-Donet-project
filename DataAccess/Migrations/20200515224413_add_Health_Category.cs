using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class add_Health_Category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "0efa9006-4c6e-4f62-b7e9-bf633e0c8b6d");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "24487564-c689-4a45-accc-201e1bfdb33c");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "41655f0b-4423-4694-8e3c-ae7cf13a4152");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { "SLD", "Salud" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[,]
                {
                    { "36cb492d-69e4-4e96-abf8-b7e09d63e480", "Corregidora #48", "Bodega central" },
                    { "754c878e-8450-4274-87e3-e19224fbb03f", "Zaragoza #35", "Bodega Norte" },
                    { "83cc98af-4ca4-4f7c-8d40-3498fdfa5260", "Amado Nervo #1203", "Bodega Oeste" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "SLD");

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

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "41655f0b-4423-4694-8e3c-ae7cf13a4152", "Corregidora #48", "Bodega central" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "0efa9006-4c6e-4f62-b7e9-bf633e0c8b6d", "Zaragoza #35", "Bodega Norte" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "24487564-c689-4a45-accc-201e1bfdb33c", "Amado Nervo #1203", "Bodega Oeste" });
        }
    }
}
