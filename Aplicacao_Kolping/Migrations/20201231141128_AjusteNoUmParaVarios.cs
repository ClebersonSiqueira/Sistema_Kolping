using Microsoft.EntityFrameworkCore.Migrations;

namespace Aplicacao_Kolping.Migrations
{
    public partial class AjusteNoUmParaVarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagamentos_Alunos_AlunosID1",
                table: "Pagamentos");

            migrationBuilder.DropIndex(
                name: "IX_Pagamentos_AlunosID1",
                table: "Pagamentos");

            migrationBuilder.DropColumn(
                name: "AlunosID1",
                table: "Pagamentos");

            migrationBuilder.DropColumn(
                name: "ModalidadeId",
                table: "Alunos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AlunosID1",
                table: "Pagamentos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModalidadeId",
                table: "Alunos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pagamentos_AlunosID1",
                table: "Pagamentos",
                column: "AlunosID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamentos_Alunos_AlunosID1",
                table: "Pagamentos",
                column: "AlunosID1",
                principalTable: "Alunos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
