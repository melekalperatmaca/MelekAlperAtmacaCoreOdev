using Microsoft.EntityFrameworkCore.Migrations;

namespace MelekAlperAtmacaCoreOdev.Data.Migrations
{
    public partial class InitializeMelekAlperAtmacaCoreOdev : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblOgrenci",
                columns: table => new
                {
                    OgrenciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciNo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Adi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Soyadi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblOgrenci", x => x.OgrenciID);
                });

            migrationBuilder.CreateTable(
                name: "TblOgrenciDers",
                columns: table => new
                {
                    OgrenciDersID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersAdi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DersKodu = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    OgrenciID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblOgrenciDers", x => x.OgrenciDersID);
                    table.ForeignKey(
                        name: "FK_TblOgrenciDers_TblOgrenci_OgrenciID",
                        column: x => x.OgrenciID,
                        principalTable: "TblOgrenci",
                        principalColumn: "OgrenciID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TblOgrenci",
                columns: new[] { "OgrenciID", "Adi", "OgrenciNo", "Soyadi" },
                values: new object[] { 1, "Melek", "1010101010", "Alper Atmaca" });

            migrationBuilder.InsertData(
                table: "TblOgrenci",
                columns: new[] { "OgrenciID", "Adi", "OgrenciNo", "Soyadi" },
                values: new object[] { 2, "Kenan Durmuş", "2010101010", "Atmaca" });

            migrationBuilder.InsertData(
                table: "TblOgrenci",
                columns: new[] { "OgrenciID", "Adi", "OgrenciNo", "Soyadi" },
                values: new object[] { 3, "Fıstık", "3010101010", "Alper Atmaca" });

            migrationBuilder.InsertData(
                table: "TblOgrenciDers",
                columns: new[] { "OgrenciDersID", "DersAdi", "DersKodu", "OgrenciID" },
                values: new object[,]
                {
                    { 1, "Yazılım", "YZLM-101", 1 },
                    { 3, "Görsel Prog.", "GRSP-101", 1 },
                    { 2, "Donanım", "DNM-101", 2 },
                    { 4, "Mikroişlemciler", "MKR-101", 2 },
                    { 5, "Havlama", "HAV-101", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblOgrenciDers_OgrenciID",
                table: "TblOgrenciDers",
                column: "OgrenciID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblOgrenciDers");

            migrationBuilder.DropTable(
                name: "TblOgrenci");
        }
    }
}
