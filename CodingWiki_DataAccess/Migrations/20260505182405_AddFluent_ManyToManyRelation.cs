using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddFluent_ManyToManyRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FluentAuthorFluentBook",
                columns: table => new
                {
                    AuthorsAuthor_Id = table.Column<int>(type: "int", nullable: false),
                    BooksBookID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FluentAuthorFluentBook", x => new { x.AuthorsAuthor_Id, x.BooksBookID });
                    table.ForeignKey(
                        name: "FK_FluentAuthorFluentBook_Fluent_Authors_AuthorsAuthor_Id",
                        column: x => x.AuthorsAuthor_Id,
                        principalTable: "Fluent_Authors",
                        principalColumn: "Author_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FluentAuthorFluentBook_Fluent_Books_BooksBookID",
                        column: x => x.BooksBookID,
                        principalTable: "Fluent_Books",
                        principalColumn: "BookID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FluentAuthorFluentBook_BooksBookID",
                table: "FluentAuthorFluentBook",
                column: "BooksBookID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FluentAuthorFluentBook");
        }
    }
}
