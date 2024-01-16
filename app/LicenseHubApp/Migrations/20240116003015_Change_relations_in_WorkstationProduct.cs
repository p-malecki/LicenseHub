using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LicenseHubApp.Migrations
{
    /// <inheritdoc />
    public partial class Change_relations_in_WorkstationProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductReleases_WorkstationProducts_WorkstationProductId",
                table: "ProductReleases");

            migrationBuilder.DropIndex(
                name: "IX_ProductReleases_WorkstationProductId",
                table: "ProductReleases");

            migrationBuilder.DropColumn(
                name: "WorkstationProductId",
                table: "ProductReleases");

            migrationBuilder.AddColumn<int>(
                name: "ReleaseID",
                table: "WorkstationProducts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_WorkstationProducts_ReleaseID",
                table: "WorkstationProducts",
                column: "ReleaseID");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkstationProducts_ProductReleases_ReleaseID",
                table: "WorkstationProducts",
                column: "ReleaseID",
                principalTable: "ProductReleases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkstationProducts_ProductReleases_ReleaseID",
                table: "WorkstationProducts");

            migrationBuilder.DropIndex(
                name: "IX_WorkstationProducts_ReleaseID",
                table: "WorkstationProducts");

            migrationBuilder.DropColumn(
                name: "ReleaseID",
                table: "WorkstationProducts");

            migrationBuilder.AddColumn<int>(
                name: "WorkstationProductId",
                table: "ProductReleases",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProductReleases_WorkstationProductId",
                table: "ProductReleases",
                column: "WorkstationProductId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductReleases_WorkstationProducts_WorkstationProductId",
                table: "ProductReleases",
                column: "WorkstationProductId",
                principalTable: "WorkstationProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
