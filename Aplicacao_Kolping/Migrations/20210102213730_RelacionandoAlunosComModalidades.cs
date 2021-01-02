using Microsoft.EntityFrameworkCore.Migrations;

namespace Aplicacao_Kolping.Migrations
{
    public partial class RelacionandoAlunosComModalidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Modalidades_ModalidadesId",
                table: "Alunos");

            migrationBuilder.DropForeignKey(
                name: "FK_Modalidades_Alunos_AlunosID",
                table: "Modalidades");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagamentos_Alunos_AlunosID",
                table: "Pagamentos");

            migrationBuilder.DropIndex(
                name: "IX_Pagamentos_AlunosID",
                table: "Pagamentos");

            migrationBuilder.DropIndex(
                name: "IX_Modalidades_AlunosID",
                table: "Modalidades");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_ModalidadesId",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "AlunosID",
                table: "Pagamentos");

            migrationBuilder.DropColumn(
                name: "AlunosID",
                table: "Modalidades");

            migrationBuilder.DropColumn(
                name: "ModalidadesId",
                table: "Alunos");

            migrationBuilder.AddColumn<int>(
                name: "AlunoID",
                table: "Pagamentos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Modalidades",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Alunos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "AlunosModalidades",
                columns: table => new
                {
                    AlunoID = table.Column<int>(nullable: false),
                    ModalidadeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunosModalidades", x => new { x.AlunoID, x.ModalidadeID });
                    table.ForeignKey(
                        name: "FK_AlunosModalidades_Alunos_AlunoID",
                        column: x => x.AlunoID,
                        principalTable: "Alunos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlunosModalidades_Modalidades_ModalidadeID",
                        column: x => x.ModalidadeID,
                        principalTable: "Modalidades",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pagamentos_AlunoID",
                table: "Pagamentos",
                column: "AlunoID");

            migrationBuilder.CreateIndex(
                name: "IX_AlunosModalidades_ModalidadeID",
                table: "AlunosModalidades",
                column: "ModalidadeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamentos_Alunos_AlunoID",
                table: "Pagamentos",
                column: "AlunoID",
                principalTable: "Alunos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagamentos_Alunos_AlunoID",
                table: "Pagamentos");

            migrationBuilder.DropTable(
                name: "AlunosModalidades");

            migrationBuilder.DropIndex(
                name: "IX_Pagamentos_AlunoID",
                table: "Pagamentos");

            migrationBuilder.DropColumn(
                name: "AlunoID",
                table: "Pagamentos");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Modalidades",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "AlunosID",
                table: "Pagamentos",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Modalidades",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "AlunosID",
                table: "Modalidades",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Alunos",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "ModalidadesId",
                table: "Alunos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pagamentos_AlunosID",
                table: "Pagamentos",
                column: "AlunosID");

            migrationBuilder.CreateIndex(
                name: "IX_Modalidades_AlunosID",
                table: "Modalidades",
                column: "AlunosID");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_ModalidadesId",
                table: "Alunos",
                column: "ModalidadesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Modalidades_ModalidadesId",
                table: "Alunos",
                column: "ModalidadesId",
                principalTable: "Modalidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Modalidades_Alunos_AlunosID",
                table: "Modalidades",
                column: "AlunosID",
                principalTable: "Alunos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamentos_Alunos_AlunosID",
                table: "Pagamentos",
                column: "AlunosID",
                principalTable: "Alunos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
