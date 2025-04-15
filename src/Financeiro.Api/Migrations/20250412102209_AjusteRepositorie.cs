using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Financeiro.Api.Migrations
{
    /// <inheritdoc />
    public partial class AjusteRepositorie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ativos_Ativos_AtivoId",
                table: "Ativos");

            migrationBuilder.DropIndex(
                name: "IX_Ativos_AtivoId",
                table: "Ativos");

            migrationBuilder.DropColumn(
                name: "AtivoId",
                table: "Ativos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AtivoId",
                table: "Ativos",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ativos_AtivoId",
                table: "Ativos",
                column: "AtivoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ativos_Ativos_AtivoId",
                table: "Ativos",
                column: "AtivoId",
                principalTable: "Ativos",
                principalColumn: "Id");
        }
    }
}
