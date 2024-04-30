using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Api_Metas.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_Metas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Meta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor = table.Column<float>(type: "real", nullable: false),
                    Tempo = table.Column<float>(type: "real", nullable: false),
                    Urgencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Classe = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Metas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TB_Metas",
                columns: new[] { "Id", "Classe", "Meta", "Nome", "Tempo", "Urgencia", "Valor" },
                values: new object[,]
                {
                    { 1, 0, "Compra uma moto", "Luiz", 2f, "baixa", 10000f },
                    { 2, 0, "Compra uma casa", "Asteris", 20f, "baixa", 400000f },
                    { 3, 0, "Compra um vestido", "Elizabete", 1f, "alta", 400f },
                    { 4, 0, "Compra uma TV", "Rafael", 1f, "alta", 2000f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_Metas");
        }
    }
}
