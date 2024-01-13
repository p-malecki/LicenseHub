using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LicenseHubApp.Migrations
{
    /// <inheritdoc />
    public partial class AddStoreProduct_AddStoreProductRelease : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StoreProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    IsAvailable = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StoreProductReleases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StoreProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    ReleaseNumber = table.Column<string>(type: "TEXT", nullable: false),
                    InstallerVerificationPasscode = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreProductReleases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StoreProductReleases_StoreProducts_StoreProductId",
                        column: x => x.StoreProductId,
                        principalTable: "StoreProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StoreProductReleases_ReleaseNumber",
                table: "StoreProductReleases",
                column: "ReleaseNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StoreProductReleases_StoreProductId",
                table: "StoreProductReleases",
                column: "StoreProductId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreProducts_Name",
                table: "StoreProducts",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StoreProductReleases");

            migrationBuilder.DropTable(
                name: "StoreProducts");
        }
    }
}
