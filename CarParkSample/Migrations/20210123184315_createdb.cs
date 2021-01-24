using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CarParkSample.Migrations
{
    public partial class createdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AltBolges",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Alt_Bolge = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AltBolges", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Bölges",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Bolge = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bölges", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ilces",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ilce = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ilces", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Lokasyons",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Lokasyon_Adi = table.Column<string>(type: "text", nullable: true),
                    Lokasyon_Kodu = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lokasyons", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Park_Adi = table.Column<string>(type: "text", nullable: true),
                    Park_Kapasitesi = table.Column<string>(type: "text", nullable: true),
                    Calisma_Saatleri = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ParkTipis",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Park_Tipi = table.Column<string>(type: "text", nullable: true),
                    Park_Kapasitesi = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkTipis", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Records",
                columns: table => new
                {
                    _id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ParkID = table.Column<int>(type: "integer", nullable: false),
                    Adres = table.Column<string>(type: "text", nullable: true),
                    Enlem_Boylam = table.Column<string>(type: "text", nullable: true),
                    Boylam = table.Column<double>(type: "double precision", nullable: false),
                    Enlem = table.Column<double>(type: "double precision", nullable: false),
                    Polygon_Verisi = table.Column<string>(type: "geography", nullable: true),
                    Aylik_Abonelik_Ucreti = table.Column<double>(type: "double precision", nullable: false),
                    Ucretsiz_Parklanma_Suresi_dakika = table.Column<int>(type: "integer", nullable: false),
                    Tarifesi = table.Column<string>(type: "text", nullable: true),
                    Park_Et_Devam_Et_Noktasi = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Records", x => x._id);
                    table.ForeignKey(
                        name: "FK_Records_Parks_ParkID",
                        column: x => x.ParkID,
                        principalTable: "Parks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Records_ParkID",
                table: "Records",
                column: "ParkID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AltBolges");

            migrationBuilder.DropTable(
                name: "Bölges");

            migrationBuilder.DropTable(
                name: "ilces");

            migrationBuilder.DropTable(
                name: "Lokasyons");

            migrationBuilder.DropTable(
                name: "ParkTipis");

            migrationBuilder.DropTable(
                name: "Records");

            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
