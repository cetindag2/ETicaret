using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETicaretAPI.Persistence.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_Orders_OrderID",
                table: "Baskets");

            migrationBuilder.DropIndex(
                name: "IX_Baskets_OrderID",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "OrderID",
                table: "Baskets");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Baskets_ID",
                table: "Orders",
                column: "ID",
                principalTable: "Baskets",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Baskets_ID",
                table: "Orders");

            migrationBuilder.AddColumn<Guid>(
                name: "OrderID",
                table: "Baskets",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_OrderID",
                table: "Baskets",
                column: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_Orders_OrderID",
                table: "Baskets",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
