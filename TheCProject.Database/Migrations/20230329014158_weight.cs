using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheCProject.Database.Migrations
{
    public partial class weight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Weight",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Weight",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Weight");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Weight");
        }
    }
}
