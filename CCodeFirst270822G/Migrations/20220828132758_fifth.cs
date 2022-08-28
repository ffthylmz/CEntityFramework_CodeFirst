using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CCodeFirst270822G.Migrations
{
    public partial class fifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SupplierID",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Product_SupplierID",
                table: "Product",
                column: "SupplierID");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Suppliers_SupplierID",
                table: "Product",
                column: "SupplierID",
                principalTable: "Suppliers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Suppliers_SupplierID",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_SupplierID",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "SupplierID",
                table: "Product");
        }
    }
}
