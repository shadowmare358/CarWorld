using Microsoft.EntityFrameworkCore.Migrations;

namespace CarWorld.Data.Migrations
{
    public partial class RatingsCorrectionAddUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "Ratings",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_UserID",
                table: "Ratings",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_AspNetUsers_UserID",
                table: "Ratings",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_AspNetUsers_UserID",
                table: "Ratings");

            migrationBuilder.DropIndex(
                name: "IX_Ratings_UserID",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Ratings");
        }
    }
}
