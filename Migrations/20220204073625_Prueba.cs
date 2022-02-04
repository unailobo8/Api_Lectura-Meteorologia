using Microsoft.EntityFrameworkCore.Migrations;

namespace Api_base.Migrations
{
    public partial class Prueba : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Balizas",
                columns: table => new
                {
                    Municipio = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Temperatura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Humedad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Velocidad_Viento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Precipitacion_acumulada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ultimaHora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imagen = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Balizas", x => x.Municipio);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Balizas");
        }
    }
}
