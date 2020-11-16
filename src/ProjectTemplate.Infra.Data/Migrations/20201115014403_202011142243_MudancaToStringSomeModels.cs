using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectTemplate.Infra.Data.Migrations
{
    public partial class _202011142243_MudancaToStringSomeModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UTM_Y",
                table: "EdificacoesMoradores",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "TELEFONE",
                table: "EdificacoesMoradores",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "SEXO",
                table: "EdificacoesMoradores",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "RELACAO_FAMILIAR",
                table: "EdificacoesMoradores",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "RELACAO",
                table: "EdificacoesMoradores",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "PONTO_ENCONTRO",
                table: "EdificacoesMoradores",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "NOME",
                table: "EdificacoesMoradores",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "IDENT_GLOBAL",
                table: "EdificacoesMoradores",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "IDADE",
                table: "EdificacoesMoradores",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "UTM_Y",
                table: "EdificacoesMoradores",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TELEFONE",
                table: "EdificacoesMoradores",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "SEXO",
                table: "EdificacoesMoradores",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "RELACAO_FAMILIAR",
                table: "EdificacoesMoradores",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "RELACAO",
                table: "EdificacoesMoradores",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "PONTO_ENCONTRO",
                table: "EdificacoesMoradores",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "NOME",
                table: "EdificacoesMoradores",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "IDENT_GLOBAL",
                table: "EdificacoesMoradores",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "IDADE",
                table: "EdificacoesMoradores",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
