using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blue.Cup.Api.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Star = table.Column<int>(type: "INTEGER", nullable: false),
                    Stars = table.Column<int>(type: "INTEGER", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: false),
                    Review = table.Column<string>(type: "TEXT", nullable: false),
                    ItemID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rating_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ID");
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ID", "Brand", "Description", "Name", "Price" },
                values: new object[] { 1, "Nike", "Ohio State shirt", "Shirt", 29.99m });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ID", "Brand", "Description", "Name", "Price" },
                values: new object[] { 2, "Nike", "Ohio State shorts", "Shorts", 44.99m });

            migrationBuilder.CreateIndex(
                name: "IX_Rating_ItemID",
                table: "Rating",
                column: "ItemID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
