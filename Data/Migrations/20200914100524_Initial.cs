using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(nullable: false),
                    InnerBarcode = table.Column<string>(maxLength: 50, nullable: true),
                    CategoryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[] { new Guid("ee4611dd-82b1-4c30-94e1-579c9b7b2820"), false, "Elektronik" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[] { new Guid("a837cf99-e02a-4d4a-9a7e-44f0b6166c24"), false, "Kırtasiye" });

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

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
