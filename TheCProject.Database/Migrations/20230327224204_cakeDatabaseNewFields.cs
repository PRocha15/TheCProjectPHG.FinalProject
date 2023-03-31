using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheCProject.Database.Migrations
{
    public partial class cakeDatabaseNewFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Cake",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateUser",
                table: "Cake",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Identifier",
                table: "Cake",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Cake",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdateUser",
                table: "Cake",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Cake");

            migrationBuilder.DropColumn(
                name: "CreateUser",
                table: "Cake");

            migrationBuilder.DropColumn(
                name: "Identifier",
                table: "Cake");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Cake");

            migrationBuilder.DropColumn(
                name: "UpdateUser",
                table: "Cake");
        }
    }
}
