using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KVCGayrimenkul.DataAccessLayer.Migrations
{
    public partial class mig_add_relation_advertisement_advertisementType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdvertisementTypeID",
                table: "Advertisements",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_AdvertisementTypeID",
                table: "Advertisements",
                column: "AdvertisementTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisements_AdvertisementTypes_AdvertisementTypeID",
                table: "Advertisements",
                column: "AdvertisementTypeID",
                principalTable: "AdvertisementTypes",
                principalColumn: "AdvertisementTypeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertisements_AdvertisementTypes_AdvertisementTypeID",
                table: "Advertisements");

            migrationBuilder.DropIndex(
                name: "IX_Advertisements_AdvertisementTypeID",
                table: "Advertisements");

            migrationBuilder.DropColumn(
                name: "AdvertisementTypeID",
                table: "Advertisements");
        }


    }
}
