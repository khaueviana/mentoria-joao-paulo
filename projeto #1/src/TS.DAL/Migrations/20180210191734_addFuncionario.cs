using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TS.DAL.Migrations
{
    public partial class addFuncionario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RelatorioVendaId",
                table: "Sessoes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientesId",
                table: "Relatorios",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sessoes_RelatorioVendaId",
                table: "Sessoes",
                column: "RelatorioVendaId");

            migrationBuilder.CreateIndex(
                name: "IX_Relatorios_ClientesId",
                table: "Relatorios",
                column: "ClientesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Relatorios_Clientes_ClientesId",
                table: "Relatorios",
                column: "ClientesId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sessoes_Relatorios_RelatorioVendaId",
                table: "Sessoes",
                column: "RelatorioVendaId",
                principalTable: "Relatorios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Relatorios_Clientes_ClientesId",
                table: "Relatorios");

            migrationBuilder.DropForeignKey(
                name: "FK_Sessoes_Relatorios_RelatorioVendaId",
                table: "Sessoes");

            migrationBuilder.DropIndex(
                name: "IX_Sessoes_RelatorioVendaId",
                table: "Sessoes");

            migrationBuilder.DropIndex(
                name: "IX_Relatorios_ClientesId",
                table: "Relatorios");

            migrationBuilder.DropColumn(
                name: "RelatorioVendaId",
                table: "Sessoes");

            migrationBuilder.DropColumn(
                name: "ClientesId",
                table: "Relatorios");
        }
    }
}
