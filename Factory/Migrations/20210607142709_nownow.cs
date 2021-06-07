using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class nownow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyInt",
                table: "Machines");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Machines");

            migrationBuilder.AddColumn<string>(
                name: "Production",
                table: "Machines",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Production",
                table: "Machines");

            migrationBuilder.AddColumn<int>(
                name: "MyInt",
                table: "Machines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Machines",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
