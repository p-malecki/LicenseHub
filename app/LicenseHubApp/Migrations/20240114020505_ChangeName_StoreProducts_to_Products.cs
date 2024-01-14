using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LicenseHubApp.Migrations
{
    /// <inheritdoc />
    public partial class ChangeName_StoreProducts_to_Products : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StoreProductReleases_Products_ProductId",
                table: "StoreProductReleases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StoreProductReleases",
                table: "StoreProductReleases");

            migrationBuilder.RenameTable(
                name: "StoreProductReleases",
                newName: "ProductReleases");

            migrationBuilder.RenameIndex(
                name: "IX_StoreProductReleases_ReleaseNumber",
                table: "ProductReleases",
                newName: "IX_ProductReleases_ReleaseNumber");

            migrationBuilder.RenameIndex(
                name: "IX_StoreProductReleases_ProductId",
                table: "ProductReleases",
                newName: "IX_ProductReleases_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductReleases",
                table: "ProductReleases",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductReleases_Products_ProductId",
                table: "ProductReleases",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductReleases_Products_ProductId",
                table: "ProductReleases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductReleases",
                table: "ProductReleases");

            migrationBuilder.RenameTable(
                name: "ProductReleases",
                newName: "StoreProductReleases");

            migrationBuilder.RenameIndex(
                name: "IX_ProductReleases_ReleaseNumber",
                table: "StoreProductReleases",
                newName: "IX_StoreProductReleases_ReleaseNumber");

            migrationBuilder.RenameIndex(
                name: "IX_ProductReleases_ProductId",
                table: "StoreProductReleases",
                newName: "IX_StoreProductReleases_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoreProductReleases",
                table: "StoreProductReleases",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StoreProductReleases_Products_ProductId",
                table: "StoreProductReleases",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
