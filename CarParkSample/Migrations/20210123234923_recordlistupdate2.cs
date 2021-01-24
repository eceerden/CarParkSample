using Microsoft.EntityFrameworkCore.Migrations;

namespace CarParkSample.Migrations
{
    public partial class recordlistupdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Boylam",
                table: "Records",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Enlem",
                table: "Records",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Polygon_Verisi",
                table: "Records",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Boylam",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "Enlem",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "Polygon_Verisi",
                table: "Records");
        }
    }
}
