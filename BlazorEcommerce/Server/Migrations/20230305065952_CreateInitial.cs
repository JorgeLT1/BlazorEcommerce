using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class CreateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagenUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImagenUrl", "Price", "Title" },
                values: new object[] { 1, "Lo que el viento se llevó es un drama romántico o, según algunos críticos, un melodrama. La novela gira en torno a la historia de la joven Scarlett O'Hara, integrante de una familia aristócrata sureña, en tiempos de la Guerra de Secesión.", "https://www.hislibris.com/wp-content/uploads/2007/06/Sense-t%C3%ADtol.jpg", 9.99m, "Lo que el viento se llevó" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImagenUrl", "Price", "Title" },
                values: new object[] { 2, "La historia narra el día a día de dos ratones, Fisgón y Escurridizo, y dos liliputienses, Kif y Kof. Los cuatro protagonistas pasan sus días corriendo por los pasillos de un laberinto en busca de queso, alimento del que dependen para nutrirse y ser felices.", "https://www.resumenlibro.com/img/libros/quien-se-ha-llevado-mi-queso.jpg", 7.99m, "¿Quién se ha llevado mi queso?" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImagenUrl", "Price", "Title" },
                values: new object[] { 3, "De aspecto pálido, alto, delgado, nariz puntiaguda, tiene Barba y bigote. Es el protagonista de la novela y constituye un consagrado mito de la literatura universal, y el más universal y profundo de la literatura española.", "https://lalibretadenani.files.wordpress.com/2020/07/don-quijote.jpg", 6.99m, "Don Quijote de la Mancha" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
