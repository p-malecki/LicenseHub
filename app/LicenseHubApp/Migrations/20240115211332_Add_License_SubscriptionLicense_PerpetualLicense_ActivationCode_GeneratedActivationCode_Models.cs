using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LicenseHubApp.Migrations
{
    /// <inheritdoc />
    public partial class Add_License_SubscriptionLicense_PerpetualLicense_ActivationCode_GeneratedActivationCode_Models : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivationCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Code = table.Column<string>(type: "TEXT", nullable: false),
                    LicenseId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivationCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeneratedActivationCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Code = table.Column<string>(type: "TEXT", nullable: false),
                    LicenseId = table.Column<int>(type: "INTEGER", nullable: false),
                    CodeGeneratorVersion = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneratedActivationCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PerpetualLicenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ActivationDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerpetualLicenses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionLicenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ActivationDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LeaseTermInDays = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionLicenses", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivationCodes_LicenseId",
                table: "ActivationCodes",
                column: "LicenseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GeneratedActivationCodes_LicenseId",
                table: "GeneratedActivationCodes",
                column: "LicenseId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivationCodes");

            migrationBuilder.DropTable(
                name: "GeneratedActivationCodes");

            migrationBuilder.DropTable(
                name: "PerpetualLicenses");

            migrationBuilder.DropTable(
                name: "SubscriptionLicenses");
        }
    }
}
