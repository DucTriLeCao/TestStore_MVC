using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestStoreWeb.Migrations
{
    /// <inheritdoc />
    public partial class addProductToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "Category",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price10 = table.Column<double>(type: "float", nullable: false),
                    Price20 = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Brand", "ListPrice", "Price", "Price10", "Price20", "ProductDescription", "ProductName", "Quantity" },
                values: new object[,]
                {
                    { 1, "Nutifood", 520.0, 500.0, 495.0, 485.0, "Sữa bột cho bé trên 2 tuổi", "Sữa bột 850g Varma", 550 },
                    { 2, "Huggies", 450.0, 430.0, 420.0, 410.0, "Tã quần cao cấp, thoáng mát", "Tã quần Huggies size M 74 miếng", 200 },
                    { 3, "Lego", 1200.0, 1150.0, 1130.0, 1100.0, "Bộ đồ chơi lắp ráp phát triển trí tuệ cho bé", "Đồ chơi lắp ráp Lego Classic 900 mảnh", 150 },
                    { 4, "Gap", 250.0, 240.0, 235.0, 230.0, "Áo thun cotton mềm mại, thoáng mát", "Áo thun cotton GAP bé trai size M", 350 },
                    { 5, "Pediakid", 300.0, 280.0, 270.0, 260.0, "Vitamin tổng hợp giúp tăng cường sức khỏe cho trẻ", "Vitamin tổng hợp Pediakid cho trẻ em", 500 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);
        }
    }
}
