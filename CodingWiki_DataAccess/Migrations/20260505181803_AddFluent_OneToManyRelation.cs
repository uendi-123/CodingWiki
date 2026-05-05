using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddFluent_OneToManyRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Publisher_ID",
                table: "Fluent_Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_Books_Publisher_ID",
                table: "Fluent_Books",
                column: "Publisher_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_Books_Fluent_Publisher_Publisher_ID",
                table: "Fluent_Books",
                column: "Publisher_ID",
                principalTable: "Fluent_Publisher",
                principalColumn: "Publisher_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_Books_Fluent_Publisher_Publisher_ID",
                table: "Fluent_Books");

            migrationBuilder.DropIndex(
                name: "IX_Fluent_Books_Publisher_ID",
                table: "Fluent_Books");

            migrationBuilder.DropColumn(
                name: "Publisher_ID",
                table: "Fluent_Books");
        }
    }
}
