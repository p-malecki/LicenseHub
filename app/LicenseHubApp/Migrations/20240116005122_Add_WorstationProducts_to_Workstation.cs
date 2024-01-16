using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LicenseHubApp.Migrations
{
    /// <inheritdoc />
    public partial class Add_WorstationProducts_to_Workstation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkstationProducts_ProductReleases_ReleaseID",
                table: "WorkstationProducts");

            migrationBuilder.RenameColumn(
                name: "ReleaseID",
                table: "WorkstationProducts",
                newName: "ReleaseId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkstationProducts_ReleaseID",
                table: "WorkstationProducts",
                newName: "IX_WorkstationProducts_ReleaseId");

            migrationBuilder.AddColumn<int>(
                name: "WorkstationId",
                table: "WorkstationProducts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_WorkstationProducts_WorkstationId",
                table: "WorkstationProducts",
                column: "WorkstationId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkstationProducts_ProductReleases_ReleaseId",
                table: "WorkstationProducts",
                column: "ReleaseId",
                principalTable: "ProductReleases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkstationProducts_Workstations_WorkstationId",
                table: "WorkstationProducts",
                column: "WorkstationId",
                principalTable: "Workstations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkstationProducts_ProductReleases_ReleaseId",
                table: "WorkstationProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkstationProducts_Workstations_WorkstationId",
                table: "WorkstationProducts");

            migrationBuilder.DropIndex(
                name: "IX_WorkstationProducts_WorkstationId",
                table: "WorkstationProducts");

            migrationBuilder.DropColumn(
                name: "WorkstationId",
                table: "WorkstationProducts");

            migrationBuilder.RenameColumn(
                name: "ReleaseId",
                table: "WorkstationProducts",
                newName: "ReleaseID");

            migrationBuilder.RenameIndex(
                name: "IX_WorkstationProducts_ReleaseId",
                table: "WorkstationProducts",
                newName: "IX_WorkstationProducts_ReleaseID");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkstationProducts_ProductReleases_ReleaseID",
                table: "WorkstationProducts",
                column: "ReleaseID",
                principalTable: "ProductReleases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
