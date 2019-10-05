using Microsoft.EntityFrameworkCore.Migrations;

namespace AulaDotNetCore.Repositorio.Migrations
{
    public partial class AlterarTamanhoColunaPreco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "preco",
                table: "Produtos",
                newName: "Preco");

            migrationBuilder.AlterColumn<decimal>(
                name: "Preco",
                table: "Produtos",
                type: "decimal(19,4",
                nullable: false,
                oldClrType: typeof(decimal));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "Produtos",
                newName: "preco");

            migrationBuilder.AlterColumn<decimal>(
                name: "preco",
                table: "Produtos",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19,4");
        }
    }
}
