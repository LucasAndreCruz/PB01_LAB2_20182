using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SGCV.Infrastructure.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Consultas",
                columns: table => new
                {
                    ConsultaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateTime>(nullable: false),
                    Observacao = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultas", x => x.ConsultaId);
                });

            migrationBuilder.CreateTable(
                name: "Especies",
                columns: table => new
                {
                    EspecieId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especies", x => x.EspecieId);
                });

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    EnderecoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Logradouro = table.Column<string>(type: "varchar(200)", nullable: true),
                    Bairro = table.Column<string>(type: "varchar(200)", nullable: true),
                    CEP = table.Column<string>(type: "varchar(10)", nullable: true),
                    Numero = table.Column<string>(type: "varchar(10)", nullable: true),
                    ClienteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.EnderecoId);
                    table.ForeignKey(
                        name: "FK_Enderecos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Idade = table.Column<int>(nullable: false),
                    Sexo = table.Column<string>(type: "varchar(5)", nullable: true),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: true),
                    ClienteId = table.Column<int>(nullable: false),
                    EspecieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                    table.ForeignKey(
                        name: "FK_Animals_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Animals_Especies_EspecieId",
                        column: x => x.EspecieId,
                        principalTable: "Especies",
                        principalColumn: "EspecieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MarcarConsulta",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AnimalId = table.Column<int>(nullable: false),
                    ConsultaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarcarConsulta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MarcarConsulta_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "AnimalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MarcarConsulta_Consultas_ConsultaId",
                        column: x => x.ConsultaId,
                        principalTable: "Consultas",
                        principalColumn: "ConsultaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ClienteId", "Email", "Nome" },
                values: new object[] { 1, "lucasandre@gmail.com", "Lucas André" });

            migrationBuilder.InsertData(
                table: "Consultas",
                columns: new[] { "ConsultaId", "Data", "Observacao" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Consulta de Rotina" });

            migrationBuilder.InsertData(
                table: "Especies",
                columns: new[] { "EspecieId", "Descricao" },
                values: new object[] { 1, "PitBull" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "ClienteId", "EspecieId", "Idade", "Nome", "Sexo" },
                values: new object[] { 1, 1, 1, 2, "Chulin", "Macho" });

            migrationBuilder.InsertData(
                table: "Enderecos",
                columns: new[] { "EnderecoId", "Bairro", "CEP", "ClienteId", "Logradouro", "Numero" },
                values: new object[] { 1, "CPA III", "78058-326", 1, "Rua cinco, Quandra 04", "180" });

            migrationBuilder.InsertData(
                table: "MarcarConsulta",
                columns: new[] { "Id", "AnimalId", "ConsultaId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Animals_ClienteId",
                table: "Animals",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_EspecieId",
                table: "Animals",
                column: "EspecieId");

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_ClienteId",
                table: "Enderecos",
                column: "ClienteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MarcarConsulta_AnimalId",
                table: "MarcarConsulta",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_MarcarConsulta_ConsultaId",
                table: "MarcarConsulta",
                column: "ConsultaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "MarcarConsulta");

            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Consultas");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Especies");
        }
    }
}
