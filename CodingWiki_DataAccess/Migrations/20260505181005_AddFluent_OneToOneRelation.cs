using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddFluent_OneToOneRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Book_ID",
                table: "Fluent_BookDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_BookDetails_Book_ID",
                table: "Fluent_BookDetails",
                column: "Book_ID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_BookDetails_Fluent_Books_Book_ID",
                table: "Fluent_BookDetails",
                column: "Book_ID",
                principalTable: "Fluent_Books",
                principalColumn: "BookID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_BookDetails_Fluent_Books_Book_ID",
                table: "Fluent_BookDetails");

            migrationBuilder.DropIndex(
                name: "IX_Fluent_BookDetails_Book_ID",
                table: "Fluent_BookDetails");

            migrationBuilder.DropColumn(
                name: "Book_ID",
                table: "Fluent_BookDetails");
        }
    }
}
