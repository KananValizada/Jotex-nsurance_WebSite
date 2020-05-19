using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class modelsUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AboutUs_Settings_SettingsId",
                table: "AboutUs");

            migrationBuilder.DropColumn(
                name: "SettingId",
                table: "AboutUs");

            migrationBuilder.AlterColumn<int>(
                name: "SettingsId",
                table: "AboutUs",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AboutUs_Settings_SettingsId",
                table: "AboutUs",
                column: "SettingsId",
                principalTable: "Settings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AboutUs_Settings_SettingsId",
                table: "AboutUs");

            migrationBuilder.AlterColumn<int>(
                name: "SettingsId",
                table: "AboutUs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "SettingId",
                table: "AboutUs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_AboutUs_Settings_SettingsId",
                table: "AboutUs",
                column: "SettingsId",
                principalTable: "Settings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
