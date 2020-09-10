using Microsoft.EntityFrameworkCore.Migrations;

namespace SsmPtvMovil.Web.Migrations
{
    public partial class AddRelationsTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Store",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StateId",
                table: "City",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Store_CityId",
                table: "Store",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_City_StateId",
                table: "City",
                column: "StateId");

            migrationBuilder.AddForeignKey(
                name: "FK_City_State_StateId",
                table: "City",
                column: "StateId",
                principalTable: "State",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Store_City_CityId",
                table: "Store",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_State_StateId",
                table: "City");

            migrationBuilder.DropForeignKey(
                name: "FK_Store_City_CityId",
                table: "Store");

            migrationBuilder.DropIndex(
                name: "IX_Store_CityId",
                table: "Store");

            migrationBuilder.DropIndex(
                name: "IX_City_StateId",
                table: "City");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Store");

            migrationBuilder.DropColumn(
                name: "StateId",
                table: "City");
        }
    }
}
