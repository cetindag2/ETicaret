using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETicaretAPI.Persistence.Migrations
{
    public partial class mig_9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Files_Products_ProductID",
                table: "Files");

            migrationBuilder.DropIndex(
                name: "IX_Files_ProductID",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "Files");

            migrationBuilder.CreateTable(
                name: "ProductProductImageFile",
                columns: table => new
                {
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductImageFilesID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductProductImageFile", x => new { x.ProductID, x.ProductImageFilesID });
                    table.ForeignKey(
                        name: "FK_ProductProductImageFile_Files_ProductImageFilesID",
                        column: x => x.ProductImageFilesID,
                        principalTable: "Files",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductProductImageFile_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductProductImageFile_ProductImageFilesID",
                table: "ProductProductImageFile",
                column: "ProductImageFilesID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductProductImageFile");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductID",
                table: "Files",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Files_ProductID",
                table: "Files",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Products_ProductID",
                table: "Files",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
