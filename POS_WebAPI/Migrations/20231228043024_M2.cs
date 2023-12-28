using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POS_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class M2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Section_Section_Id",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Section");

            migrationBuilder.DropColumn(
                name: "Total_Item",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "Section_Id",
                table: "Orders",
                newName: "Source_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_Section_Id",
                table: "Orders",
                newName: "IX_Orders_Source_Id");

            migrationBuilder.CreateTable(
                name: "Sources",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Desctiption = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Create_At = table.Column<DateTime>(type: "datetime", nullable: false),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sources", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Sources_Source_Id",
                table: "Orders",
                column: "Source_Id",
                principalTable: "Sources",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Sources_Source_Id",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Sources");

            migrationBuilder.RenameColumn(
                name: "Source_Id",
                table: "Orders",
                newName: "Section_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_Source_Id",
                table: "Orders",
                newName: "IX_Orders_Section_Id");

            migrationBuilder.AddColumn<int>(
                name: "Total_Item",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Section",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Create_At = table.Column<DateTime>(type: "datetime", nullable: false),
                    Desctiption = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Section_Section_Id",
                table: "Orders",
                column: "Section_Id",
                principalTable: "Section",
                principalColumn: "Id");
        }
    }
}
