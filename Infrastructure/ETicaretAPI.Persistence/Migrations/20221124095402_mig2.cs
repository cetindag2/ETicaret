
using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETicaretAPI.Persistence.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Baskets",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baskets", x => x.ID);
                    //table.ForeignKey(
                    //    name: "FK_Baskets_AspNetUsers_UserId",
                    //    column: x => x.UserId,
                    //    principalTable: "AspNetUsers",
                    //    principalColumn: "Id",
                    //    onDelete: ReferentialAction.Cascade);
                    //table.ForeignKey(
                    //    name: "FK_Baskets_Orders_OrderID",
                    //    column: x => x.OrderID,
                    //    principalTable: "Orders",
                    //    principalColumn: "ID",
                    //    onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BaketItems",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BasketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaketItems", x => x.ID);
                    //table.ForeignKey(
                    //    name: "FK_BaketItems_Baskets_BasketId",
                    //    column: x => x.BasketId,
                    //    principalTable: "Baskets",
                    //    principalColumn: "ID",
                    //    onDelete: ReferentialAction.Cascade);
                    //table.ForeignKey(
                    //    name: "FK_BaketItems_Products_ProductId",
                    //    column: x => x.ProductId,
                    //    principalTable: "Products",
                    //    principalColumn: "ID",
                    //    onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaketItems_BasketId",
                table: "BaketItems",
                column: "BasketId");

            migrationBuilder.CreateIndex(
                name: "IX_BaketItems_ProductId",
                table: "BaketItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_OrderID",
                table: "Baskets",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_UserId",
                table: "Baskets",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaketItems");

            migrationBuilder.DropTable(
                name: "Baskets");
        }
    }
}
