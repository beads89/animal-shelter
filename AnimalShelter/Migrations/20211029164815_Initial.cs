using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cats",
                columns: table => new
                {
                    CatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CatName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    CatGender = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    CatBreed = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    CatColor = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cats", x => x.CatId);
                });

            migrationBuilder.CreateTable(
                name: "Dogs",
                columns: table => new
                {
                    DogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DogName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    DogGender = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    DogBreed = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    DogColor = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dogs", x => x.DogId);
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "CatId", "CatBreed", "CatColor", "CatGender", "CatName" },
                values: new object[,]
                {
                    { 1, "Chocolate York", "Black, Grey", "Female", "Toey" },
                    { 2, "Bandle", "Blue, Yellow", "Female", "Yuumi" },
                    { 3, "Mixed, Calico, Tabby", "White, Brown, Cream", "Female", "Tardar Sauce" },
                    { 4, "Sphynx", "Naked", "Male", "Mr. Bigglesworth" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "DogBreed", "DogColor", "DogGender", "DogName" },
                values: new object[,]
                {
                    { 1, "Mixed, Pitbull, Terrier, Australian Shepherd", "Black, White", "Male", "Loki" },
                    { 2, "Mixed, Pitbull, Terrier", "Black, White", "Female", "Brandie" },
                    { 3, "Mixed, Vizsla, Hound, Bloodhound", "Red", "Male", "Clifford" },
                    { 4, "Siberian Husky", "Black, White", "Male", "Balto" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cats");

            migrationBuilder.DropTable(
                name: "Dogs");
        }
    }
}
