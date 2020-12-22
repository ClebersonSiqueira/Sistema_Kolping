using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aplicacao_Kolping.Migrations
{
    public partial class OtherEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AlunosID",
                table: "Modalidades",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Documento = table.Column<string>(nullable: true),
                    Nascimento = table.Column<DateTime>(nullable: false),
                    Telefone = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Rua = table.Column<string>(nullable: true),
                    NumeroCasa = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Cep = table.Column<int>(nullable: false),
                    ModalidadesID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Alunos_Modalidades_ModalidadesID",
                        column: x => x.ModalidadesID,
                        principalTable: "Modalidades",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pagamentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateTime>(nullable: false),
                    Valor = table.Column<double>(nullable: false),
                    AlunosID = table.Column<int>(nullable: true),
                    AlunosID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pagamentos_Alunos_AlunosID",
                        column: x => x.AlunosID,
                        principalTable: "Alunos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pagamentos_Alunos_AlunosID1",
                        column: x => x.AlunosID1,
                        principalTable: "Alunos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Modalidades_AlunosID",
                table: "Modalidades",
                column: "AlunosID");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_ModalidadesID",
                table: "Alunos",
                column: "ModalidadesID");

            migrationBuilder.CreateIndex(
                name: "IX_Pagamentos_AlunosID",
                table: "Pagamentos",
                column: "AlunosID");

            migrationBuilder.CreateIndex(
                name: "IX_Pagamentos_AlunosID1",
                table: "Pagamentos",
                column: "AlunosID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Modalidades_Alunos_AlunosID",
                table: "Modalidades",
                column: "AlunosID",
                principalTable: "Alunos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modalidades_Alunos_AlunosID",
                table: "Modalidades");

            migrationBuilder.DropTable(
                name: "Pagamentos");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropIndex(
                name: "IX_Modalidades_AlunosID",
                table: "Modalidades");

            migrationBuilder.DropColumn(
                name: "AlunosID",
                table: "Modalidades");
        }
    }
}
