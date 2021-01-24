using Microsoft.EntityFrameworkCore.Migrations;

namespace CarParkSample.Migrations
{
    public partial class overridetypefixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Records_Parks_ParkID",
                table: "Records");

            migrationBuilder.DropIndex(
                name: "IX_Records_ParkID",
                table: "Records");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Boylam",
                table: "Records",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Enlem",
                table: "Records",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Polygon_Verisi",
                table: "Records",
                type: "geography",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Records_ParkID",
                table: "Records",
                column: "ParkID");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Parks_ParkID",
                table: "Records",
                column: "ParkID",
                principalTable: "Parks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
