using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddOneToOneRelation_Book_BookDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BookDetailId",
                table: "BookDetails",
                newName: "BookDetail_Id");

            migrationBuilder.AddColumn<int>(
                name: "Book_ID",
                table: "BookDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BookDetails_Book_ID",
                table: "BookDetails",
                column: "Book_ID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BookDetails_Books_Book_ID",
                table: "BookDetails",
                column: "Book_ID",
                principalTable: "Books",
                principalColumn: "BookID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookDetails_Books_Book_ID",
                table: "BookDetails");

            migrationBuilder.DropIndex(
                name: "IX_BookDetails_Book_ID",
                table: "BookDetails");

            migrationBuilder.DropColumn(
                name: "Book_ID",
                table: "BookDetails");

            migrationBuilder.RenameColumn(
                name: "BookDetail_Id",
                table: "BookDetails",
                newName: "BookDetailId");
        }
    }
}
