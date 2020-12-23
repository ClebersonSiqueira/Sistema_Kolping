using Microsoft.EntityFrameworkCore.Migrations;

namespace Aplicacao_Kolping.Migrations
{
    public partial class AjustEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NumeroCasa",
                table: "Alunos",
                newName: "Numero");

            migrationBuilder.AlterColumn<string>(
                name: "Cep",
                table: "Alunos",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Numero",
                table: "Alunos",
                newName: "NumeroCasa");

            migrationBuilder.AlterColumn<int>(
                name: "Cep",
                table: "Alunos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
