using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KVCGayrimenkul.DataAccessLayer.Migrations
{
    public partial class mig_add_relation_advertisement_category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Advertisements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_CategoryID",
                table: "Advertisements",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisements_Categories_CategoryID",
                table: "Advertisements",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertisements_Categories_CategoryID",
                table: "Advertisements");

            migrationBuilder.DropIndex(
                name: "IX_Advertisements_CategoryID",
                table: "Advertisements");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Advertisements");
        }
    }
}
