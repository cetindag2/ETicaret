using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETicaretAPI.Persistence.Migrations
{
    public partial class mig_10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductProductImageFile_Products_ProductID",
                table: "ProductProductImageFile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductProductImageFile",
                table: "ProductProductImageFile");

            migrationBuilder.DropIndex(
                name: "IX_ProductProductImageFile_ProductImageFilesID",
                table: "ProductProductImageFile");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "ProductProductImageFile",
                newName: "ProductsID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductProductImageFile",
                table: "ProductProductImageFile",
                columns: new[] { "ProductImageFilesID", "ProductsID" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductProductImageFile_ProductsID",
                table: "ProductProductImageFile",
                column: "ProductsID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProductImageFile_Products_ProductsID",
                table: "ProductProductImageFile",
                column: "ProductsID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductProductImageFile_Products_ProductsID",
                table: "ProductProductImageFile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductProductImageFile",
                table: "ProductProductImageFile");

            migrationBuilder.DropIndex(
                name: "IX_ProductProductImageFile_ProductsID",
                table: "ProductProductImageFile");

            migrationBuilder.RenameColumn(
                name: "ProductsID",
                table: "ProductProductImageFile",
                newName: "ProductID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductProductImageFile",
                table: "ProductProductImageFile",
                columns: new[] { "ProductID", "ProductImageFilesID" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductProductImageFile_ProductImageFilesID",
                table: "ProductProductImageFile",
                column: "ProductImageFilesID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProductImageFile_Products_ProductID",
                table: "ProductProductImageFile",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
