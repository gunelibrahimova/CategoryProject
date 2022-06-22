using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class all : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_subCategories_categories_CategoryId",
                table: "subCategories");

            migrationBuilder.DropIndex(
                name: "IX_subCategories_CategoryId",
                table: "subCategories");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "subCategories");

            migrationBuilder.AddColumn<int>(
                name: "CategoryyId",
                table: "subCategories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_subCategories_CategoryyId",
                table: "subCategories",
                column: "CategoryyId");

            migrationBuilder.AddForeignKey(
                name: "FK_subCategories_categories_CategoryyId",
                table: "subCategories",
                column: "CategoryyId",
                principalTable: "categories",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_subCategories_categories_CategoryyId",
                table: "subCategories");

            migrationBuilder.DropIndex(
                name: "IX_subCategories_CategoryyId",
                table: "subCategories");

            migrationBuilder.DropColumn(
                name: "CategoryyId",
                table: "subCategories");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "subCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_subCategories_CategoryId",
                table: "subCategories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_subCategories_categories_CategoryId",
                table: "subCategories",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
