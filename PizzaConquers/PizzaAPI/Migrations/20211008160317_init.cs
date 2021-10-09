using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pizzas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Speciality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Crust = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzas", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Pizzas",
                columns: new[] { "ID", "Crust", "Description", "Images", "Name", "Price", "Speciality" },
                values: new object[,]
                {
                    { 1001, "Fresh Pan Pizza", "Peppy Paneer Cheese Burst Topped with Extra Cheese", "/Images/pizza-1.jpg", "Veg Loaded", 199.0, "with Pepsi" },
                    { 1002, "Fresh Pan Pizza", "Peppy Paneer Cheese Burst Topped with Extra Cheese", "/Images/pizza-2.jpg", "Peppy Paneer Pizza", 299.0, "with extra toppings" },
                    { 1003, "Fresh Pan Pizza", "Mashroon Topped", "/Images/pizza-3.jpg", "Peper Chicken", 199.0, "with Pepsi" },
                    { 1004, "Fresh Pan Pizza", "Peppy Paneer Cheese Burst Topped with Extra Cheese", "/Images/pizza-4.jpg", "Non Veg Loaded", 299.0, "with Pepsi" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pizzas");
        }
    }
}
