using Microsoft.EntityFrameworkCore.Migrations;

namespace Aplicacao_Kolping.Migrations
{
    public partial class AjustesNaChavePagamentos2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Abr",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Ago",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Dez",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Fev",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Jan",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Jul",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Jun",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Mai",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Mar",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Nov",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Out",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Set",
                table: "Alunos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Abr",
                table: "Alunos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Ago",
                table: "Alunos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Dez",
                table: "Alunos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Fev",
                table: "Alunos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Jan",
                table: "Alunos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Jul",
                table: "Alunos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Jun",
                table: "Alunos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Mai",
                table: "Alunos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Mar",
                table: "Alunos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Nov",
                table: "Alunos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Out",
                table: "Alunos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Set",
                table: "Alunos",
                nullable: false,
                defaultValue: false);
        }
    }
}
