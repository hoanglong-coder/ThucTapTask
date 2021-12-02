using Microsoft.EntityFrameworkCore.Migrations;

namespace TASK.Data.Migrations
{
    public partial class InitDb01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "DaDuyet",
                table: "CongViecs",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DaDuyet",
                table: "CongViecs");
        }
    }
}
