using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LicenseHubApp.Migrations
{
    /// <inheritdoc />
    public partial class SimplifyLicenseModel_rm_subscription_and_perpetual_licenses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PerpetualLicenses");

            migrationBuilder.DropTable(
                name: "SubscriptionLicenses");

            migrationBuilder.CreateTable(
                name: "Licenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RegisterDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ActivationDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    LeaseTermInDays = table.Column<int>(type: "INTEGER", nullable: false),
                    WorkstationProductId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Licenses_WorkstationProducts_WorkstationProductId",
                        column: x => x.WorkstationProductId,
                        principalTable: "WorkstationProducts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Licenses_WorkstationProductId",
                table: "Licenses",
                column: "WorkstationProductId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ActivationCodes_Licenses_LicenseId",
                table: "ActivationCodes",
                column: "LicenseId",
                principalTable: "Licenses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GeneratedActivationCodes_Licenses_LicenseId",
                table: "GeneratedActivationCodes",
                column: "LicenseId",
                principalTable: "Licenses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActivationCodes_Licenses_LicenseId",
                table: "ActivationCodes");

            migrationBuilder.DropForeignKey(
                name: "FK_GeneratedActivationCodes_Licenses_LicenseId",
                table: "GeneratedActivationCodes");

            migrationBuilder.DropTable(
                name: "Licenses");

            migrationBuilder.CreateTable(
                name: "PerpetualLicenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    WorkstationProductId = table.Column<int>(type: "INTEGER", nullable: true),
                    ActivationDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RegisterDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerpetualLicenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PerpetualLicenses_WorkstationProducts_WorkstationProductId",
                        column: x => x.WorkstationProductId,
                        principalTable: "WorkstationProducts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionLicenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    WorkstationProductId = table.Column<int>(type: "INTEGER", nullable: true),
                    ActivationDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RegisterDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    LeaseTermInDays = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionLicenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubscriptionLicenses_WorkstationProducts_WorkstationProductId",
                        column: x => x.WorkstationProductId,
                        principalTable: "WorkstationProducts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PerpetualLicenses_WorkstationProductId",
                table: "PerpetualLicenses",
                column: "WorkstationProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionLicenses_WorkstationProductId",
                table: "SubscriptionLicenses",
                column: "WorkstationProductId",
                unique: true);
        }
    }
}
