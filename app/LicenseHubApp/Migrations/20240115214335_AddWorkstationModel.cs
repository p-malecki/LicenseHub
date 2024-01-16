using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LicenseHubApp.Migrations
{
    /// <inheritdoc />
    public partial class AddWorkstationModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WorkstationProductId",
                table: "SubscriptionLicenses",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WorkstationProductId",
                table: "ProductReleases",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WorkstationProductId",
                table: "PerpetualLicenses",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "WorkstationProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkstationProducts", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionLicenses_WorkstationProductId",
                table: "SubscriptionLicenses",
                column: "WorkstationProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductReleases_WorkstationProductId",
                table: "ProductReleases",
                column: "WorkstationProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PerpetualLicenses_WorkstationProductId",
                table: "PerpetualLicenses",
                column: "WorkstationProductId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PerpetualLicenses_WorkstationProducts_WorkstationProductId",
                table: "PerpetualLicenses",
                column: "WorkstationProductId",
                principalTable: "WorkstationProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductReleases_WorkstationProducts_WorkstationProductId",
                table: "ProductReleases",
                column: "WorkstationProductId",
                principalTable: "WorkstationProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionLicenses_WorkstationProducts_WorkstationProductId",
                table: "SubscriptionLicenses",
                column: "WorkstationProductId",
                principalTable: "WorkstationProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PerpetualLicenses_WorkstationProducts_WorkstationProductId",
                table: "PerpetualLicenses");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductReleases_WorkstationProducts_WorkstationProductId",
                table: "ProductReleases");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionLicenses_WorkstationProducts_WorkstationProductId",
                table: "SubscriptionLicenses");

            migrationBuilder.DropTable(
                name: "WorkstationProducts");

            migrationBuilder.DropIndex(
                name: "IX_SubscriptionLicenses_WorkstationProductId",
                table: "SubscriptionLicenses");

            migrationBuilder.DropIndex(
                name: "IX_ProductReleases_WorkstationProductId",
                table: "ProductReleases");

            migrationBuilder.DropIndex(
                name: "IX_PerpetualLicenses_WorkstationProductId",
                table: "PerpetualLicenses");

            migrationBuilder.DropColumn(
                name: "WorkstationProductId",
                table: "SubscriptionLicenses");

            migrationBuilder.DropColumn(
                name: "WorkstationProductId",
                table: "ProductReleases");

            migrationBuilder.DropColumn(
                name: "WorkstationProductId",
                table: "PerpetualLicenses");
        }
    }
}
