using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LicenseHubApp.Migrations
{
    /// <inheritdoc />
    public partial class CompanyNipNotUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Companies_Nip",
                table: "Companies");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Companies_Nip",
                table: "Companies",
                column: "Nip",
                unique: true);
        }
    }
}
