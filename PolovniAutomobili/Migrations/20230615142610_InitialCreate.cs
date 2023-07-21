using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PolovniAutomobili.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Godiste = table.Column<int>(type: "int", nullable: false),
                    ZapreminaMotora = table.Column<double>(type: "float", nullable: false),
                    Snaga = table.Column<int>(type: "int", nullable: false),
                    Gorivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Karoserija = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cena = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Kontakt = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
