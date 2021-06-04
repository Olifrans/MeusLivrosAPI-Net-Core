using Microsoft.EntityFrameworkCore.Migrations;

namespace MeusLivrosAPI.Migrations
{
    public partial class ManyToManyAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Publicar_PublicarId",
                table: "Livros");

            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Autor_Autor_AutorId",
                table: "Livros_Autor");

            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Autor_Livros_LivrosId",
                table: "Livros_Autor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Publicar",
                table: "Publicar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Livros_Autor",
                table: "Livros_Autor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Autor",
                table: "Autor");

            migrationBuilder.RenameTable(
                name: "Publicar",
                newName: "Publicars");

            migrationBuilder.RenameTable(
                name: "Livros_Autor",
                newName: "Livros_Autors");

            migrationBuilder.RenameTable(
                name: "Autor",
                newName: "Autors");

            migrationBuilder.RenameIndex(
                name: "IX_Livros_Autor_LivrosId",
                table: "Livros_Autors",
                newName: "IX_Livros_Autors_LivrosId");

            migrationBuilder.RenameIndex(
                name: "IX_Livros_Autor_AutorId",
                table: "Livros_Autors",
                newName: "IX_Livros_Autors_AutorId");

            migrationBuilder.AlterColumn<int>(
                name: "PublicarId",
                table: "Livros",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Publicars",
                table: "Publicars",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Livros_Autors",
                table: "Livros_Autors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Autors",
                table: "Autors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Publicars_PublicarId",
                table: "Livros",
                column: "PublicarId",
                principalTable: "Publicars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Autors_Autors_AutorId",
                table: "Livros_Autors",
                column: "AutorId",
                principalTable: "Autors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Autors_Livros_LivrosId",
                table: "Livros_Autors",
                column: "LivrosId",
                principalTable: "Livros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Publicars_PublicarId",
                table: "Livros");

            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Autors_Autors_AutorId",
                table: "Livros_Autors");

            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Autors_Livros_LivrosId",
                table: "Livros_Autors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Publicars",
                table: "Publicars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Livros_Autors",
                table: "Livros_Autors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Autors",
                table: "Autors");

            migrationBuilder.RenameTable(
                name: "Publicars",
                newName: "Publicar");

            migrationBuilder.RenameTable(
                name: "Livros_Autors",
                newName: "Livros_Autor");

            migrationBuilder.RenameTable(
                name: "Autors",
                newName: "Autor");

            migrationBuilder.RenameIndex(
                name: "IX_Livros_Autors_LivrosId",
                table: "Livros_Autor",
                newName: "IX_Livros_Autor_LivrosId");

            migrationBuilder.RenameIndex(
                name: "IX_Livros_Autors_AutorId",
                table: "Livros_Autor",
                newName: "IX_Livros_Autor_AutorId");

            migrationBuilder.AlterColumn<int>(
                name: "PublicarId",
                table: "Livros",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Publicar",
                table: "Publicar",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Livros_Autor",
                table: "Livros_Autor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Autor",
                table: "Autor",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Publicar_PublicarId",
                table: "Livros",
                column: "PublicarId",
                principalTable: "Publicar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Autor_Autor_AutorId",
                table: "Livros_Autor",
                column: "AutorId",
                principalTable: "Autor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Autor_Livros_LivrosId",
                table: "Livros_Autor",
                column: "LivrosId",
                principalTable: "Livros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
