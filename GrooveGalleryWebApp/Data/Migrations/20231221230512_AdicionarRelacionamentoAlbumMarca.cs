using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrooveGalleryWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarRelacionamentoAlbumMarca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MarcaId",
                table: "Album",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Album_MarcaId",
                table: "Album",
                column: "MarcaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Album_Marca_MarcaId",
                table: "Album",
                column: "MarcaId",
                principalTable: "Marca",
                principalColumn: "MarcaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Album_Marca_MarcaId",
                table: "Album");

            migrationBuilder.DropIndex(
                name: "IX_Album_MarcaId",
                table: "Album");

            migrationBuilder.DropColumn(
                name: "MarcaId",
                table: "Album");
        }
    }
}
