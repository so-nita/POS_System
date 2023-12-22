using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POS_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class M_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Image = table.Column<string>(type: "varchar(550)", maxLength: 550, nullable: true),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Create_At = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Create_At = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Section",
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
                    table.PrimaryKey("PK_Section", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemTypes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Create_At = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Image = table.Column<string>(type: "varchar(550)", maxLength: 550, nullable: true),
                    Main_Category_Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Create_At = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_Category_Main_Category_Id",
                        column: x => x.Main_Category_Id,
                        principalTable: "Category",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    NameKh = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Contact = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: false),
                    System_Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Image = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true),
                    Website = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Address = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Create_At = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_SystemTypes_System_Id",
                        column: x => x.System_Id,
                        principalTable: "SystemTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    UserName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Password = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Contact = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: false),
                    Image = table.Column<string>(type: "varchar(550)", maxLength: 550, nullable: true),
                    Company_Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Role_Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: true),
                    Create_At = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Companies_Company_Id",
                        column: x => x.Company_Id,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Users_Roles_Role_Id",
                        column: x => x.Role_Id,
                        principalTable: "Roles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Sub_Total = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Total_Discount = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Total_Item = table.Column<int>(type: "int", nullable: false),
                    Company_Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: true),
                    Section_Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: true),
                    Reference_Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: true),
                    Order_Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Order_Status = table.Column<int>(type: "int", nullable: false),
                    Is_Delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Section_Section_Id",
                        column: x => x.Section_Id,
                        principalTable: "Section",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_Users_Reference_Id",
                        column: x => x.Reference_Id,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Code = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    NameKh = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Create_By = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Company_Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Company_Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Category_Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Image = table.Column<string>(type: "varchar(550)", maxLength: 550, nullable: true),
                    Cost = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Create_At = table.Column<DateTime>(type: "datetime", nullable: false),
                    Last_Update = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_SubCategories_Category_Id",
                        column: x => x.Category_Id,
                        principalTable: "SubCategories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_Users_Create_By",
                        column: x => x.Create_By,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "User_Logs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    User_Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    User_Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    User_Type = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Action = table.Column<int>(type: "int", nullable: false),
                    Create_At = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Logs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Logs_Users_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Receipts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Order_Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: true),
                    Discount = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Reference = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: true),
                    Transaction_Date = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receipts_Orders_Order_Id",
                        column: x => x.Order_Id,
                        principalTable: "Orders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Receipts_Users_Reference",
                        column: x => x.Reference,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Product_Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Order_Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Product_Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Size = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    SubTotal = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Tax = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Create_At = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_Order_Id",
                        column: x => x.Order_Id,
                        principalTable: "Orders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_Product_Id",
                        column: x => x.Product_Id,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Category_Name",
                table: "Category",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Companies_System_Id",
                table: "Companies",
                column: "System_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_Order_Id",
                table: "OrderDetails",
                column: "Order_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_Product_Id",
                table: "OrderDetails",
                column: "Product_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Reference_Id",
                table: "Orders",
                column: "Reference_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Section_Id",
                table: "Orders",
                column: "Section_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Category_Id",
                table: "Products",
                column: "Category_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Code",
                table: "Products",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_Create_By",
                table: "Products",
                column: "Create_By");

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_Order_Id",
                table: "Receipts",
                column: "Order_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_Reference",
                table: "Receipts",
                column: "Reference");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_Main_Category_Id",
                table: "SubCategories",
                column: "Main_Category_Id");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_Name",
                table: "SubCategories",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_Logs_User_Id",
                table: "User_Logs",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Company_Id",
                table: "Users",
                column: "Company_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Role_Id",
                table: "Users",
                column: "Role_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Receipts");

            migrationBuilder.DropTable(
                name: "User_Logs");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Section");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "SystemTypes");
        }
    }
}
