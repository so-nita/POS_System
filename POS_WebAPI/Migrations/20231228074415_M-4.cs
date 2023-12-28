using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POS_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class M4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Total",
                table: "Orders",
                newName: "Grand_Total");

            migrationBuilder.RenameColumn(
                name: "Total",
                table: "OrderDetails",
                newName: "Sub_Amount");

            migrationBuilder.RenameColumn(
                name: "SubTotal",
                table: "OrderDetails",
                newName: "Grand_Amount");

            migrationBuilder.RenameColumn(
                name: "Discount",
                table: "OrderDetails",
                newName: "Discount_Percent");

            migrationBuilder.AddColumn<decimal>(
                name: "Discount_Amount",
                table: "OrderDetails",
                type: "decimal(8,2)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount_Amount",
                table: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "Grand_Total",
                table: "Orders",
                newName: "Total");

            migrationBuilder.RenameColumn(
                name: "Sub_Amount",
                table: "OrderDetails",
                newName: "Total");

            migrationBuilder.RenameColumn(
                name: "Grand_Amount",
                table: "OrderDetails",
                newName: "SubTotal");

            migrationBuilder.RenameColumn(
                name: "Discount_Percent",
                table: "OrderDetails",
                newName: "Discount");
        }
    }
}
