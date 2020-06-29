using Microsoft.EntityFrameworkCore.Migrations;

namespace Smith_week4.Migrations
{
    public partial class Create_Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    TopicId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.TopicId);
                });

            migrationBuilder.CreateTable(
                name: "FAQs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(nullable: true),
                    Answer = table.Column<string>(nullable: true),
                    TopicId = table.Column<string>(nullable: true),
                    TopicsTopicId = table.Column<string>(nullable: true),
                    CategoryId = table.Column<string>(nullable: true),
                    CategoriesCategoryId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAQs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FAQs_Categories_CategoriesCategoryId",
                        column: x => x.CategoriesCategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FAQs_Topics_TopicsTopicId",
                        column: x => x.TopicsTopicId,
                        principalTable: "Topics",
                        principalColumn: "TopicId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { "gen", "General" },
                    { "hist", "History" }
                });

            migrationBuilder.InsertData(
                table: "FAQs",
                columns: new[] { "Id", "Answer", "CategoriesCategoryId", "CategoryId", "Question", "TopicId", "TopicsTopicId" },
                values: new object[,]
                {
                    { 1, "A general purpose object oriented language that uses a concise, Java-like syntax", null, "gen", "What is C#?", "cs", null },
                    { 2, "In 2002.", null, "hist", "When was C# first released?", "cs", null },
                    { 3, "A general purpose scripting language that executes in a web browser.", null, "gen", "What is JavaScript?", "js", null },
                    { 4, "In 1995.", null, "hist", "When was JavaScript first released?", "cs", null },
                    { 5, "A CSS framework for creating responsive web apps for multiple screen sizes.", null, "gen", "What is Bootstrap?", "boot", null },
                    { 6, "In 2011.", null, "hist", "When was Bootstrap first released?", "boot", null }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "TopicId", "Name" },
                values: new object[,]
                {
                    { "cs", "C#" },
                    { "js", "JavaScript" },
                    { "boot", "Bootstrap" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FAQs_CategoriesCategoryId",
                table: "FAQs",
                column: "CategoriesCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FAQs_TopicsTopicId",
                table: "FAQs",
                column: "TopicsTopicId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FAQs");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Topics");
        }
    }
}
