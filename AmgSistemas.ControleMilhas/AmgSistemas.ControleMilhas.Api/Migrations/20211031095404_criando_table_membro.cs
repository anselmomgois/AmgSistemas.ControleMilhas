using Microsoft.EntityFrameworkCore.Migrations;

namespace AmgSistemas.ControleMilhas.Api.Migrations
{
    public partial class criando_table_membro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ID_MEMBRO",
                table: "AGCM_TSALDO",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ID_USUARIO",
                table: "AGCM_TPROGRAMA",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ID_MEMBRO",
                table: "AGCM_TMOVIMENTOS",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ID_USUARIO",
                table: "AGCM_TEMPRESA",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ID_USUARIO",
                table: "AGCM_TCOTACAO",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "AGCM_TMEMBROS",
                columns: table => new
                {
                    ID_MEMBRO = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID_USUARIO = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DES_NOME = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGCM_TMEMBROS", x => x.ID_MEMBRO);
                    table.ForeignKey(
                        name: "FK_AGCM_TMEMBROS_AGCM_TUSUARIO_ID_USUARIO",
                        column: x => x.ID_USUARIO,
                        principalTable: "AGCM_TUSUARIO",
                        principalColumn: "ID_USUARIO",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AGCM_TSALDO_ID_MEMBRO",
                table: "AGCM_TSALDO",
                column: "ID_MEMBRO");

            migrationBuilder.CreateIndex(
                name: "IX_AGCM_TPROGRAMA_ID_USUARIO",
                table: "AGCM_TPROGRAMA",
                column: "ID_USUARIO");

            migrationBuilder.CreateIndex(
                name: "IX_AGCM_TMOVIMENTOS_ID_MEMBRO",
                table: "AGCM_TMOVIMENTOS",
                column: "ID_MEMBRO");

            migrationBuilder.CreateIndex(
                name: "IX_AGCM_TEMPRESA_ID_USUARIO",
                table: "AGCM_TEMPRESA",
                column: "ID_USUARIO");

            migrationBuilder.CreateIndex(
                name: "IX_AGCM_TCOTACAO_ID_USUARIO",
                table: "AGCM_TCOTACAO",
                column: "ID_USUARIO");

            migrationBuilder.CreateIndex(
                name: "IX_AGCM_TMEMBROS_ID_USUARIO",
                table: "AGCM_TMEMBROS",
                column: "ID_USUARIO");

            migrationBuilder.AddForeignKey(
                name: "FK_AGCM_TCOTACAO_AGCM_TUSUARIO_ID_USUARIO",
                table: "AGCM_TCOTACAO",
                column: "ID_USUARIO",
                principalTable: "AGCM_TUSUARIO",
                principalColumn: "ID_USUARIO",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AGCM_TEMPRESA_AGCM_TUSUARIO_ID_USUARIO",
                table: "AGCM_TEMPRESA",
                column: "ID_USUARIO",
                principalTable: "AGCM_TUSUARIO",
                principalColumn: "ID_USUARIO",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AGCM_TMOVIMENTOS_AGCM_TMEMBROS_ID_MEMBRO",
                table: "AGCM_TMOVIMENTOS",
                column: "ID_MEMBRO",
                principalTable: "AGCM_TMEMBROS",
                principalColumn: "ID_MEMBRO",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AGCM_TPROGRAMA_AGCM_TUSUARIO_ID_USUARIO",
                table: "AGCM_TPROGRAMA",
                column: "ID_USUARIO",
                principalTable: "AGCM_TUSUARIO",
                principalColumn: "ID_USUARIO",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AGCM_TSALDO_AGCM_TMEMBROS_ID_MEMBRO",
                table: "AGCM_TSALDO",
                column: "ID_MEMBRO",
                principalTable: "AGCM_TMEMBROS",
                principalColumn: "ID_MEMBRO",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AGCM_TCOTACAO_AGCM_TUSUARIO_ID_USUARIO",
                table: "AGCM_TCOTACAO");

            migrationBuilder.DropForeignKey(
                name: "FK_AGCM_TEMPRESA_AGCM_TUSUARIO_ID_USUARIO",
                table: "AGCM_TEMPRESA");

            migrationBuilder.DropForeignKey(
                name: "FK_AGCM_TMOVIMENTOS_AGCM_TMEMBROS_ID_MEMBRO",
                table: "AGCM_TMOVIMENTOS");

            migrationBuilder.DropForeignKey(
                name: "FK_AGCM_TPROGRAMA_AGCM_TUSUARIO_ID_USUARIO",
                table: "AGCM_TPROGRAMA");

            migrationBuilder.DropForeignKey(
                name: "FK_AGCM_TSALDO_AGCM_TMEMBROS_ID_MEMBRO",
                table: "AGCM_TSALDO");

            migrationBuilder.DropTable(
                name: "AGCM_TMEMBROS");

            migrationBuilder.DropIndex(
                name: "IX_AGCM_TSALDO_ID_MEMBRO",
                table: "AGCM_TSALDO");

            migrationBuilder.DropIndex(
                name: "IX_AGCM_TPROGRAMA_ID_USUARIO",
                table: "AGCM_TPROGRAMA");

            migrationBuilder.DropIndex(
                name: "IX_AGCM_TMOVIMENTOS_ID_MEMBRO",
                table: "AGCM_TMOVIMENTOS");

            migrationBuilder.DropIndex(
                name: "IX_AGCM_TEMPRESA_ID_USUARIO",
                table: "AGCM_TEMPRESA");

            migrationBuilder.DropIndex(
                name: "IX_AGCM_TCOTACAO_ID_USUARIO",
                table: "AGCM_TCOTACAO");

            migrationBuilder.DropColumn(
                name: "ID_MEMBRO",
                table: "AGCM_TSALDO");

            migrationBuilder.DropColumn(
                name: "ID_USUARIO",
                table: "AGCM_TPROGRAMA");

            migrationBuilder.DropColumn(
                name: "ID_MEMBRO",
                table: "AGCM_TMOVIMENTOS");

            migrationBuilder.DropColumn(
                name: "ID_USUARIO",
                table: "AGCM_TEMPRESA");

            migrationBuilder.DropColumn(
                name: "ID_USUARIO",
                table: "AGCM_TCOTACAO");
        }
    }
}
