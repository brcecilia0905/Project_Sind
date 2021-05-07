using Microsoft.EntityFrameworkCore.Migrations;

namespace SindOnibus.Migrations
{
    public partial class ImageURL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Cadastros",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Cadastros");
        }
    }
}
