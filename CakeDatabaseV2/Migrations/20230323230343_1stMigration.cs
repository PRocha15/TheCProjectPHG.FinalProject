using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CakeDatabase.Migrations
{
    public partial class _1stMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cakes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CakeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CakeDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cakeconfeccion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CakeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Statuts = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cakes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ClientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CakeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderRequest = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderCheckout = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Statuts = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CakeFile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileBytes = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileExtension = table.Column<int>(type: "int", nullable: false),
                    FileChecksum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CakeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CakeFlavour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CakeID = table.Column<int>(type: "int", nullable: false),
                    Statuts = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CakeFile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CakeFile_Cakes_CakeID",
                        column: x => x.CakeID,
                        principalTable: "Cakes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CakeFile_CakeID",
                table: "CakeFile",
                column: "CakeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CakeFile");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Cakes");
        }
    }
}
