using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LicenseHubApp.Migrations
{
    /// <inheritdoc />
    public partial class WorkstationProductIsNullableForLicenses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PerpetualLicenses_WorkstationProducts_WorkstationProductId",
                table: "PerpetualLicenses");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionLicenses_WorkstationProducts_WorkstationProductId",
                table: "SubscriptionLicenses");

            migrationBuilder.AlterColumn<int>(
                name: "WorkstationProductId",
                table: "SubscriptionLicenses",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "WorkstationProductId",
                table: "PerpetualLicenses",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_PerpetualLicenses_WorkstationProducts_WorkstationProductId",
                table: "PerpetualLicenses",
                column: "WorkstationProductId",
                principalTable: "WorkstationProducts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionLicenses_WorkstationProducts_WorkstationProductId",
                table: "SubscriptionLicenses",
                column: "WorkstationProductId",
                principalTable: "WorkstationProducts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PerpetualLicenses_WorkstationProducts_WorkstationProductId",
                table: "PerpetualLicenses");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionLicenses_WorkstationProducts_WorkstationProductId",
                table: "SubscriptionLicenses");

            migrationBuilder.AlterColumn<int>(
                name: "WorkstationProductId",
                table: "SubscriptionLicenses",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "WorkstationProductId",
                table: "PerpetualLicenses",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PerpetualLicenses_WorkstationProducts_WorkstationProductId",
                table: "PerpetualLicenses",
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
    }
}
