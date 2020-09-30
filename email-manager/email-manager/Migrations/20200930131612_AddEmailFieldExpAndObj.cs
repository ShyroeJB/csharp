using Microsoft.EntityFrameworkCore.Migrations;

namespace email_manager.Migrations
{
    public partial class AddEmailFieldExpAndObj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Expeditor",
                table: "Email",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Object",
                table: "Email",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Expeditor",
                table: "Email");

            migrationBuilder.DropColumn(
                name: "Object",
                table: "Email");
        }
    }
}
