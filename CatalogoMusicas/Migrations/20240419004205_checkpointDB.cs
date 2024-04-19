using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatalogoMusicas.Migrations
{
    /// <inheritdoc />
    public partial class checkpointDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_musica",
                columns: table => new
                {
                    IdMusica = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Album = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Artista = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Genero = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Titulo = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    TotalReproducoes = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    TotalCurtidas = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Classificacao = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_musica", x => x.IdMusica);
                });

            migrationBuilder.CreateTable(
                name: "tb_podcast",
                columns: table => new
                {
                    IdPodcast = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Host = table.Column<string>(type: "NVARCHAR2(80)", maxLength: 80, nullable: false),
                    Descricao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Titulo = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    TotalReproducoes = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    TotalCurtidas = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Classificacao = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_podcast", x => x.IdPodcast);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_musica");

            migrationBuilder.DropTable(
                name: "tb_podcast");
        }
    }
}
