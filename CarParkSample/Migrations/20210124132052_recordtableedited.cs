using Microsoft.EntityFrameworkCore.Migrations;

namespace CarParkSample.Migrations
{
    public partial class recordtableedited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Polygon_Verisi",
                table: "Records",
                type: "text",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AltBolge",
                table: "Records",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AltBolgeID",
                table: "Records",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Bolge",
                table: "Records",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BolgeID",
                table: "Records",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CalismaSaatleri",
                table: "Records",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ilce",
                table: "Records",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IlceID",
                table: "Records",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LokasyonAdi",
                table: "Records",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LokasyonID",
                table: "Records",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LokasyonKodu",
                table: "Records",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ParkAdi",
                table: "Records",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParkKapasitesi",
                table: "Records",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParkTipi",
                table: "Records",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParkTipiID",
                table: "Records",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AltBolge",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "AltBolgeID",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "Bolge",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "BolgeID",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "CalismaSaatleri",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "Ilce",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "IlceID",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "LokasyonAdi",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "LokasyonID",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "LokasyonKodu",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "ParkAdi",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "ParkKapasitesi",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "ParkTipi",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "ParkTipiID",
                table: "Records");

            migrationBuilder.AlterColumn<decimal>(
                name: "Polygon_Verisi",
                table: "Records",
                type: "numeric",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }
    }
}
