using Microsoft.EntityFrameworkCore.Migrations;

namespace ejercicioSITHEC.Migrations
{
    public partial class addModelHumano : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HumanoItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    Sexo = table.Column<string>(nullable: false),
                    Edad = table.Column<int>(nullable: false),
                    Altura = table.Column<double>(nullable: false),
                    Peso = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HumanoItems", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HumanoItems");
        }
    }
}
