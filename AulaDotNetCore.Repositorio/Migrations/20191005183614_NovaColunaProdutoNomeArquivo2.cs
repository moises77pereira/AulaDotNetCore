using Microsoft.EntityFrameworkCore.Migrations;

namespace AulaDotNetCore.Repositorio.Migrations
{
    public partial class NovaColunaProdutoNomeArquivo2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NomeArquivo",
                table: "Produtos",
                maxLength: 40,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NomeArquivo",
                table: "Produtos",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 40,
                oldNullable: true);
        }
    }
}
