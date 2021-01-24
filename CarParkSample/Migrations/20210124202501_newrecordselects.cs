using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CarParkSample.Migrations
{
    public partial class newrecordselects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RecordSelects",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    _id = table.Column<int>(type: "integer", nullable: false),
                    ParkID = table.Column<int>(type: "integer", nullable: false),
                    ParkAdi = table.Column<string>(type: "text", nullable: true),
                    LokasyonID = table.Column<int>(type: "integer", nullable: false),
                    LokasyonKodu = table.Column<int>(type: "integer", nullable: false),
                    LokasyonAdi = table.Column<string>(type: "text", nullable: true),
                    ParkTipiID = table.Column<int>(type: "integer", nullable: false),
                    ParkTipi = table.Column<string>(type: "text", nullable: true),
                    ParkKapasitesi = table.Column<string>(type: "text", nullable: true),
                    CalismaSaatleri = table.Column<string>(type: "text", nullable: true),
                    BolgeID = table.Column<int>(type: "integer", nullable: false),
                    Bolge = table.Column<string>(type: "text", nullable: true),
                    AltBolgeID = table.Column<int>(type: "integer", nullable: false),
                    AltBolge = table.Column<string>(type: "text", nullable: true),
                    IlceID = table.Column<int>(type: "integer", nullable: false),
                    Ilce = table.Column<string>(type: "text", nullable: true),
                    Adres = table.Column<string>(type: "text", nullable: true),
                    Enlem_Boylam = table.Column<string>(type: "text", nullable: true),
                    Boylam = table.Column<decimal>(type: "numeric", nullable: true),
                    Enlem = table.Column<decimal>(type: "numeric", nullable: true),
                    Polygon_Verisi = table.Column<string>(type: "text", nullable: true),
                    Aylik_Abonelik_Ucreti = table.Column<double>(type: "double precision", nullable: true),
                    Ucretsiz_Parklanma_Suresi_dakika = table.Column<int>(type: "integer", nullable: false),
                    Tarifesi = table.Column<string>(type: "text", nullable: true),
                    Park_Et_Devam_Et_Noktasi = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecordSelects", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecordSelects");
        }
    }
}
