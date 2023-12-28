using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POS_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class M_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tax",
                table: "OrderDetails");

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Products",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Tax",
                table: "Orders",
                type: "decimal(8,2)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Tax",
                table: "Orders");

            migrationBuilder.AddColumn<decimal>(
                name: "Tax",
                table: "OrderDetails",
                type: "decimal(8,2)",
                nullable: true);
        }
    }
}
