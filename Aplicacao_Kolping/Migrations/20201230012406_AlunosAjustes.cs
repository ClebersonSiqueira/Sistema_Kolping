using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aplicacao_Kolping.Migrations
{
    public partial class AlunosAjustes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Modalidades_ModalidadesID",
                table: "Alunos");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Modalidades",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ModalidadesID",
                table: "Alunos",
                newName: "ModalidadesId");

            migrationBuilder.RenameIndex(
                name: "IX_Alunos_ModalidadesID",
                table: "Alunos",
                newName: "IX_Alunos_ModalidadesId");

            migrationBuilder.AddColumn<DateTime>(
                name: "DiadePagamento",
                table: "Alunos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Modalidades_ModalidadesId",
                table: "Alunos",
                column: "ModalidadesId",
                principalTable: "Modalidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Modalidades_ModalidadesId",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "DiadePagamento",
                table: "Alunos");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Modalidades",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "ModalidadesId",
                table: "Alunos",
                newName: "ModalidadesID");

            migrationBuilder.RenameIndex(
                name: "IX_Alunos_ModalidadesId",
                table: "Alunos",
                newName: "IX_Alunos_ModalidadesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Modalidades_ModalidadesID",
                table: "Alunos",
                column: "ModalidadesID",
                principalTable: "Modalidades",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
