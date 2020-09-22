using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class _22092020DbGuncellendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5a87c22a-04e4-4053-8013-25b6e0fb80a1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6019a554-a60e-497f-8cf2-3d722ede7a8a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("786bf428-177a-4e94-bde5-64eb9ec67a9c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d848782b-1968-4cc6-9f62-e50b1f389011"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ed374727-ca96-4e4b-95e7-3921083f8528"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fa358af7-5709-4311-b0dc-f61f24af4923"));

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    SurName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "InnerBarcode", "IsDeleted", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { new Guid("9ab5eefa-011e-4da0-a915-721a0a760ee5"), new Guid("ee4611dd-82b1-4c30-94e1-579c9b7b2820"), null, false, "Monitor", 2000.50m, 0 },
                    { new Guid("1da279c8-4b6f-4b5c-949a-8de07238dda6"), new Guid("ee4611dd-82b1-4c30-94e1-579c9b7b2820"), null, false, "Klavye", 100.50m, 0 },
                    { new Guid("5f3ec948-531c-44e4-ba3c-fc5503288852"), new Guid("ee4611dd-82b1-4c30-94e1-579c9b7b2820"), null, false, "Laptop", 4000.50m, 0 },
                    { new Guid("eae4b3e8-1848-409e-a1d6-0f8790e4c273"), new Guid("ee4611dd-82b1-4c30-94e1-579c9b7b2820"), null, false, "Masaüstü", 5000.50m, 0 },
                    { new Guid("63225b0b-8cd0-4d13-90e0-13f9f231b223"), new Guid("a837cf99-e02a-4d4a-9a7e-44f0b6166c24"), null, false, "Kalem", 2000.50m, 0 },
                    { new Guid("6efae425-d1aa-4191-92c9-38c245ff9350"), new Guid("a837cf99-e02a-4d4a-9a7e-44f0b6166c24"), null, false, "Kitap", 2000.50m, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1da279c8-4b6f-4b5c-949a-8de07238dda6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5f3ec948-531c-44e4-ba3c-fc5503288852"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("63225b0b-8cd0-4d13-90e0-13f9f231b223"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6efae425-d1aa-4191-92c9-38c245ff9350"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9ab5eefa-011e-4da0-a915-721a0a760ee5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eae4b3e8-1848-409e-a1d6-0f8790e4c273"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "InnerBarcode", "IsDeleted", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { new Guid("5a87c22a-04e4-4053-8013-25b6e0fb80a1"), new Guid("ee4611dd-82b1-4c30-94e1-579c9b7b2820"), null, false, "Monitor", 2000.50m, 0 },
                    { new Guid("ed374727-ca96-4e4b-95e7-3921083f8528"), new Guid("ee4611dd-82b1-4c30-94e1-579c9b7b2820"), null, false, "Klavye", 100.50m, 0 },
                    { new Guid("6019a554-a60e-497f-8cf2-3d722ede7a8a"), new Guid("ee4611dd-82b1-4c30-94e1-579c9b7b2820"), null, false, "Laptop", 4000.50m, 0 },
                    { new Guid("d848782b-1968-4cc6-9f62-e50b1f389011"), new Guid("ee4611dd-82b1-4c30-94e1-579c9b7b2820"), null, false, "Masaüstü", 5000.50m, 0 },
                    { new Guid("786bf428-177a-4e94-bde5-64eb9ec67a9c"), new Guid("a837cf99-e02a-4d4a-9a7e-44f0b6166c24"), null, false, "Kalem", 2000.50m, 0 },
                    { new Guid("fa358af7-5709-4311-b0dc-f61f24af4923"), new Guid("a837cf99-e02a-4d4a-9a7e-44f0b6166c24"), null, false, "Kitap", 2000.50m, 0 }
                });
        }
    }
}
