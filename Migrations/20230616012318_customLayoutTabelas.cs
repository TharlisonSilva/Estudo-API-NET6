using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estudo_API_NET6.Migrations
{
    /// <inheritdoc />
    public partial class customLayoutTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TITULO",
                table: "Filmes",
                newName: "Titulo");

            migrationBuilder.RenameColumn(
                name: "GENERO",
                table: "Filmes",
                newName: "Genero");

            migrationBuilder.RenameColumn(
                name: "DURACAO",
                table: "Filmes",
                newName: "Duracao");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Filmes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "NUMERO",
                table: "Enderecos",
                newName: "Numero");

            migrationBuilder.RenameColumn(
                name: "LOGRADOURO",
                table: "Enderecos",
                newName: "Logradouro");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Enderecos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "NOME",
                table: "Cinemas",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Cinemas",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Titulo",
                table: "Filmes",
                newName: "TITULO");

            migrationBuilder.RenameColumn(
                name: "Genero",
                table: "Filmes",
                newName: "GENERO");

            migrationBuilder.RenameColumn(
                name: "Duracao",
                table: "Filmes",
                newName: "DURACAO");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Filmes",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Numero",
                table: "Enderecos",
                newName: "NUMERO");

            migrationBuilder.RenameColumn(
                name: "Logradouro",
                table: "Enderecos",
                newName: "LOGRADOURO");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Enderecos",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Cinemas",
                newName: "NOME");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cinemas",
                newName: "ID");
        }
    }
}
