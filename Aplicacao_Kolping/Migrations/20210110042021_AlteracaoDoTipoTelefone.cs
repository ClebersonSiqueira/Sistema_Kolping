using Microsoft.EntityFrameworkCore.Migrations;

namespace Aplicacao_Kolping.Migrations
{
    public partial class AlteracaoDoTipoTelefone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValorTotal",
                table: "Alunos");

            migrationBuilder.AlterColumn<long>(
                name: "Telefone",
                table: "Alunos",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Telefone",
                table: "Alunos",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<double>(
                name: "ValorTotal",
                table: "Alunos",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
