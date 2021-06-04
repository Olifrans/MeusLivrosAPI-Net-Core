using Microsoft.EntityFrameworkCore.Migrations;

namespace MeusLivrosAPI.Migrations
{
    public partial class LivrosAutorColumnRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Autor",
                table: "Livros");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Autor",
                table: "Livros",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
