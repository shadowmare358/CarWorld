using Microsoft.EntityFrameworkCore.Migrations;

namespace CarWorld.Data.Migrations
{
    public partial class ImageTableCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "ImageModel",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "ImageModel");
        }
    }
}
