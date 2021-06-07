using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Founded",
                table: "Details");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Details",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Details");

            migrationBuilder.AddColumn<int>(
                name: "Founded",
                table: "Details",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
