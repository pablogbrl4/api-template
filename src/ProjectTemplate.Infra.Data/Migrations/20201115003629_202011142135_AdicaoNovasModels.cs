using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectTemplate.Infra.Data.Migrations
{
    public partial class _202011142135_AdicaoNovasModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Edificacoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COD_EDIFICACAO = table.Column<string>(nullable: false),
                    UTM_X = table.Column<string>(nullable: true),
                    UTM_Y = table.Column<string>(nullable: true),
                    LAT = table.Column<string>(nullable: true),
                    LONG = table.Column<string>(nullable: true),
                    IDENT_GLOBAL = table.Column<string>(nullable: true),
                    TIPO_LOGRADOURO = table.Column<string>(nullable: true),
                    NOME_LOGRADOURO = table.Column<string>(nullable: true),
                    NUMERO = table.Column<string>(nullable: true),
                    COMPLEMENTO = table.Column<string>(nullable: true),
                    BAIRRO = table.Column<string>(nullable: true),
                    LOCALIDADE = table.Column<string>(nullable: true),
                    N_RESIDENTES = table.Column<string>(nullable: true),
                    FUNCIONARIOS = table.Column<string>(nullable: true),
                    PONTO_ENCONTRO = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Edificacoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EdificacoesMoradores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COD_EDIFICACAO = table.Column<string>(nullable: false),
                    UTM_X = table.Column<string>(nullable: true),
                    UTM_Y = table.Column<double>(nullable: false),
                    LAT = table.Column<double>(nullable: false),
                    LONG_ = table.Column<double>(nullable: false),
                    IDENT_GLOBAL = table.Column<double>(nullable: false),
                    RELACAO = table.Column<double>(nullable: false),
                    NOME = table.Column<double>(nullable: false),
                    RELACAO_FAMILIAR = table.Column<double>(nullable: false),
                    TELEFONE = table.Column<double>(nullable: false),
                    SEXO = table.Column<double>(nullable: false),
                    IDADE = table.Column<double>(nullable: false),
                    PONTO_ENCONTRO = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EdificacoesMoradores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PontosEncontro",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Nome_Refer = table.Column<string>(nullable: true),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    X = table.Column<double>(nullable: false),
                    Y = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PontosEncontro", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Edificacoes_COD_EDIFICACAO",
                table: "Edificacoes",
                column: "COD_EDIFICACAO",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EdificacoesMoradores_COD_EDIFICACAO",
                table: "EdificacoesMoradores",
                column: "COD_EDIFICACAO",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Edificacoes");

            migrationBuilder.DropTable(
                name: "EdificacoesMoradores");

            migrationBuilder.DropTable(
                name: "PontosEncontro");
        }
    }
}
