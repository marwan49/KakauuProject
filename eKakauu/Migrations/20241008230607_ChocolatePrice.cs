using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eKakauu.Migrations
{
    public partial class ChocolatePrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cocoas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Harvest = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CocoaType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cocoas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "chocolates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChocolateProcessing = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Flavor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Validity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    imageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChocolateTypek = table.Column<int>(type: "int", nullable: false),
                    CocoaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chocolates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_chocolates_Cocoas_CocoaId",
                        column: x => x.CocoaId,
                        principalTable: "Cocoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_chocolates_CocoaId",
                table: "chocolates",
                column: "CocoaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "chocolates");

            migrationBuilder.DropTable(
                name: "Cocoas");
        }
    }
}
