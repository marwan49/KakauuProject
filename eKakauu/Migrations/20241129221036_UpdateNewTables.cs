using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eKakauu.Migrations
{
    public partial class UpdateNewTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_chocolates_Cocoas_CocoaId",
                table: "chocolates");

            migrationBuilder.DropTable(
                name: "Cocoas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_chocolates",
                table: "chocolates");

            migrationBuilder.RenameTable(
                name: "chocolates",
                newName: "Chocolates");

            migrationBuilder.RenameColumn(
                name: "CocoaId",
                table: "Chocolates",
                newName: "BrandId");

            migrationBuilder.RenameIndex(
                name: "IX_chocolates_CocoaId",
                table: "Chocolates",
                newName: "IX_Chocolates_BrandId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Chocolates",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Flavor",
                table: "Chocolates",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ChocolateProcessing",
                table: "Chocolates",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Chocolates",
                table: "Chocolates",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChocolateId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stocks_Chocolates_ChocolateId",
                        column: x => x.ChocolateId,
                        principalTable: "Chocolates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChocolateId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_Chocolates_ChocolateId",
                        column: x => x.ChocolateId,
                        principalTable: "Chocolates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_ChocolateId",
                table: "ShoppingCarts",
                column: "ChocolateId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_UserId",
                table: "ShoppingCarts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ChocolateId",
                table: "Stocks",
                column: "ChocolateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chocolates_Brands_BrandId",
                table: "Chocolates",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chocolates_Brands_BrandId",
                table: "Chocolates");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Chocolates",
                table: "Chocolates");

            migrationBuilder.RenameTable(
                name: "Chocolates",
                newName: "chocolates");

            migrationBuilder.RenameColumn(
                name: "BrandId",
                table: "chocolates",
                newName: "CocoaId");

            migrationBuilder.RenameIndex(
                name: "IX_Chocolates_BrandId",
                table: "chocolates",
                newName: "IX_chocolates_CocoaId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "chocolates",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Flavor",
                table: "chocolates",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ChocolateProcessing",
                table: "chocolates",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AddPrimaryKey(
                name: "PK_chocolates",
                table: "chocolates",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Cocoas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CocoaType = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Harvest = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cocoas", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_chocolates_Cocoas_CocoaId",
                table: "chocolates",
                column: "CocoaId",
                principalTable: "Cocoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
