using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AmgSistemas.ControleMilhas.Api.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AGCM_TEMPRESA",
                columns: table => new
                {
                    ID_EMPRESA = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DES_EMPRESA = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGCM_TEMPRESA", x => x.ID_EMPRESA);
                });

            migrationBuilder.CreateTable(
                name: "AGCM_TPROGRAMA",
                columns: table => new
                {
                    ID_PROGRAMA = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DES_PROGRAMA = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGCM_TPROGRAMA", x => x.ID_PROGRAMA);
                });

            migrationBuilder.CreateTable(
                name: "AGCM_TUSUARIO",
                columns: table => new
                {
                    ID_USUARIO = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DTH_REGISTRO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DES_NOME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DES_LOGIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DES_SENHA = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGCM_TUSUARIO", x => x.ID_USUARIO);
                });

            migrationBuilder.CreateTable(
                name: "AGCM_TCOTACAO",
                columns: table => new
                {
                    ID_COTACAO = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID_EMPRESA = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID_PROGRAMA = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DTH_COTACAO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NUM_VALOR = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGCM_TCOTACAO", x => x.ID_COTACAO);
                    table.ForeignKey(
                        name: "FK_AGCM_TCOTACAO_AGCM_TEMPRESA_ID_EMPRESA",
                        column: x => x.ID_EMPRESA,
                        principalTable: "AGCM_TEMPRESA",
                        principalColumn: "ID_EMPRESA",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AGCM_TCOTACAO_AGCM_TPROGRAMA_ID_PROGRAMA",
                        column: x => x.ID_PROGRAMA,
                        principalTable: "AGCM_TPROGRAMA",
                        principalColumn: "ID_PROGRAMA",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AGCM_TMOVIMENTOS",
                columns: table => new
                {
                    ID_MOVIMENTOS = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID_USUARIO = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID_PROGRAMA = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DTH_MOVIMENTO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DES_MOVIMENTO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NUM_VALOR_TOTAL_GASTO = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QTD_PARCELAS = table.Column<int>(type: "int", nullable: false),
                    COD_TIPO = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGCM_TMOVIMENTOS", x => x.ID_MOVIMENTOS);
                    table.ForeignKey(
                        name: "FK_AGCM_TMOVIMENTOS_AGCM_TPROGRAMA_ID_PROGRAMA",
                        column: x => x.ID_PROGRAMA,
                        principalTable: "AGCM_TPROGRAMA",
                        principalColumn: "ID_PROGRAMA",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AGCM_TMOVIMENTOS_AGCM_TUSUARIO_ID_USUARIO",
                        column: x => x.ID_USUARIO,
                        principalTable: "AGCM_TUSUARIO",
                        principalColumn: "ID_USUARIO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AGCM_TSALDO",
                columns: table => new
                {
                    ID_SALDO = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID_USUARIO = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID_PROGRAMA = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NUM_VALOR_COMPRA = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NUM_MILHAS = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NUM_MILHAS_VENDIDAS = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DTH_REGISTRO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DTH_MODIFICACAO = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGCM_TSALDO", x => x.ID_SALDO);
                    table.ForeignKey(
                        name: "FK_AGCM_TSALDO_AGCM_TPROGRAMA_ID_PROGRAMA",
                        column: x => x.ID_PROGRAMA,
                        principalTable: "AGCM_TPROGRAMA",
                        principalColumn: "ID_PROGRAMA",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AGCM_TSALDO_AGCM_TUSUARIO_ID_USUARIO",
                        column: x => x.ID_USUARIO,
                        principalTable: "AGCM_TUSUARIO",
                        principalColumn: "ID_USUARIO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AGCM_TMOV_PARCELA",
                columns: table => new
                {
                    ID_MOV_PARCELA = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID_MOVIMENTOS = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NUM_VALOR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NUM_MILHAS = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DTH_PAGAMENTO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NUM_VALOR_MILHEIRO = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BOL_MILHAS_RECEBIDAS = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGCM_TMOV_PARCELA", x => x.ID_MOV_PARCELA);
                    table.ForeignKey(
                        name: "FK_AGCM_TMOV_PARCELA_AGCM_TMOVIMENTOS_ID_MOVIMENTOS",
                        column: x => x.ID_MOVIMENTOS,
                        principalTable: "AGCM_TMOVIMENTOS",
                        principalColumn: "ID_MOVIMENTOS",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AGCM_TSALDO_VENDA",
                columns: table => new
                {
                    ID_SALDO_VENDA = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID_SALDO = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID_EMPRESA = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NUM_MILHAS_VENDIDAS = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NUM_VALOR_MILHEIRO = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DTH_REGISTRO = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGCM_TSALDO_VENDA", x => x.ID_SALDO_VENDA);
                    table.ForeignKey(
                        name: "FK_AGCM_TSALDO_VENDA_AGCM_TEMPRESA_ID_EMPRESA",
                        column: x => x.ID_EMPRESA,
                        principalTable: "AGCM_TEMPRESA",
                        principalColumn: "ID_EMPRESA",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AGCM_TSALDO_VENDA_AGCM_TSALDO_ID_SALDO",
                        column: x => x.ID_SALDO,
                        principalTable: "AGCM_TSALDO",
                        principalColumn: "ID_SALDO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AGCM_TCOTACAO_ID_EMPRESA",
                table: "AGCM_TCOTACAO",
                column: "ID_EMPRESA");

            migrationBuilder.CreateIndex(
                name: "IX_AGCM_TCOTACAO_ID_PROGRAMA",
                table: "AGCM_TCOTACAO",
                column: "ID_PROGRAMA");

            migrationBuilder.CreateIndex(
                name: "IX_AGCM_TMOV_PARCELA_ID_MOVIMENTOS",
                table: "AGCM_TMOV_PARCELA",
                column: "ID_MOVIMENTOS");

            migrationBuilder.CreateIndex(
                name: "IX_AGCM_TMOVIMENTOS_ID_PROGRAMA",
                table: "AGCM_TMOVIMENTOS",
                column: "ID_PROGRAMA");

            migrationBuilder.CreateIndex(
                name: "IX_AGCM_TMOVIMENTOS_ID_USUARIO",
                table: "AGCM_TMOVIMENTOS",
                column: "ID_USUARIO");

            migrationBuilder.CreateIndex(
                name: "IX_AGCM_TSALDO_ID_PROGRAMA",
                table: "AGCM_TSALDO",
                column: "ID_PROGRAMA");

            migrationBuilder.CreateIndex(
                name: "IX_AGCM_TSALDO_ID_USUARIO",
                table: "AGCM_TSALDO",
                column: "ID_USUARIO");

            migrationBuilder.CreateIndex(
                name: "IX_AGCM_TSALDO_VENDA_ID_EMPRESA",
                table: "AGCM_TSALDO_VENDA",
                column: "ID_EMPRESA");

            migrationBuilder.CreateIndex(
                name: "IX_AGCM_TSALDO_VENDA_ID_SALDO",
                table: "AGCM_TSALDO_VENDA",
                column: "ID_SALDO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AGCM_TCOTACAO");

            migrationBuilder.DropTable(
                name: "AGCM_TMOV_PARCELA");

            migrationBuilder.DropTable(
                name: "AGCM_TSALDO_VENDA");

            migrationBuilder.DropTable(
                name: "AGCM_TMOVIMENTOS");

            migrationBuilder.DropTable(
                name: "AGCM_TEMPRESA");

            migrationBuilder.DropTable(
                name: "AGCM_TSALDO");

            migrationBuilder.DropTable(
                name: "AGCM_TPROGRAMA");

            migrationBuilder.DropTable(
                name: "AGCM_TUSUARIO");
        }
    }
}
