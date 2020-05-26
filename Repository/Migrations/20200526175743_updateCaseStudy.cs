using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class updateCaseStudy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AgentId",
                table: "CaseStudy",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CaseStudy_AgentId",
                table: "CaseStudy",
                column: "AgentId");

            migrationBuilder.AddForeignKey(
                name: "FK_CaseStudy_Agents_AgentId",
                table: "CaseStudy",
                column: "AgentId",
                principalTable: "Agents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CaseStudy_Agents_AgentId",
                table: "CaseStudy");

            migrationBuilder.DropIndex(
                name: "IX_CaseStudy_AgentId",
                table: "CaseStudy");

            migrationBuilder.DropColumn(
                name: "AgentId",
                table: "CaseStudy");
        }
    }
}
