using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taste.Migrations
{
    public partial class removeTreatID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flavors_Treats_TreatId",
                table: "Flavors");

            migrationBuilder.DropIndex(
                name: "IX_Flavors_TreatId",
                table: "Flavors");

            migrationBuilder.DropColumn(
                name: "FlavorDescription",
                table: "Flavors");

            migrationBuilder.DropColumn(
                name: "TreatId",
                table: "Flavors");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FlavorDescription",
                table: "Flavors",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "TreatId",
                table: "Flavors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Flavors_TreatId",
                table: "Flavors",
                column: "TreatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Flavors_Treats_TreatId",
                table: "Flavors",
                column: "TreatId",
                principalTable: "Treats",
                principalColumn: "TreatId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
