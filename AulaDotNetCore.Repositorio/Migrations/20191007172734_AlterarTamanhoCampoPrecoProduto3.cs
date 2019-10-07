using Microsoft.EntityFrameworkCore.Migrations;

namespace AulaDotNetCore.Repositorio.Migrations
{
    public partial class AlterarTamanhoCampoPrecoProduto3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NomeArquivo",
                table: "Produtos",
                maxLength: 45,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 40,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Produtos",
                maxLength: 450,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 400);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NomeArquivo",
                table: "Produtos",
                maxLength: 40,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 45,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Produtos",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 450);
        }
    }
}
