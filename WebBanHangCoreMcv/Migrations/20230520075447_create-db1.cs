using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBanHangCoreMcv.Migrations
{
    public partial class createdb1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParrentId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParrentId",
                table: "Categories");
        }
    }
}
