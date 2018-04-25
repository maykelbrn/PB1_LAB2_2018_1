using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SGLOC.Infrastructure.Migrations
{
    public partial class AdicionaRelacionamentoDasClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MarcaId",
                table: "Veiculo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Locacao",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VeiculoId",
                table: "Locacao",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Endereco",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo_MarcaId",
                table: "Veiculo",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Locacao_ClienteId",
                table: "Locacao",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Locacao_VeiculoId",
                table: "Locacao",
                column: "VeiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_ClienteId",
                table: "Endereco",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Cliente_ClienteId",
                table: "Endereco",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Locacao_Cliente_ClienteId",
                table: "Locacao",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Locacao_Veiculo_VeiculoId",
                table: "Locacao",
                column: "VeiculoId",
                principalTable: "Veiculo",
                principalColumn: "VeiculoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculo_Marca_MarcaId",
                table: "Veiculo",
                column: "MarcaId",
                principalTable: "Marca",
                principalColumn: "MarcaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Cliente_ClienteId",
                table: "Endereco");

            migrationBuilder.DropForeignKey(
                name: "FK_Locacao_Cliente_ClienteId",
                table: "Locacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Locacao_Veiculo_VeiculoId",
                table: "Locacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Veiculo_Marca_MarcaId",
                table: "Veiculo");

            migrationBuilder.DropIndex(
                name: "IX_Veiculo_MarcaId",
                table: "Veiculo");

            migrationBuilder.DropIndex(
                name: "IX_Locacao_ClienteId",
                table: "Locacao");

            migrationBuilder.DropIndex(
                name: "IX_Locacao_VeiculoId",
                table: "Locacao");

            migrationBuilder.DropIndex(
                name: "IX_Endereco_ClienteId",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "MarcaId",
                table: "Veiculo");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Locacao");

            migrationBuilder.DropColumn(
                name: "VeiculoId",
                table: "Locacao");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Endereco");
        }
    }
}
