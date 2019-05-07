using Microsoft.EntityFrameworkCore.Migrations;

namespace AngCore.API.Migrations
{
    public partial class TodoInitMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Todos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Completed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Completed", "Description", "Name" },
                values: new object[] { 1, false, "Clean your room.", "Clean your room." });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Completed", "Description", "Name" },
                values: new object[] { 2, false, "Clean your room.", "Hang the pictures" });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Completed", "Description", "Name" },
                values: new object[] { 3, false, "Finish coding the todo app.", "Finish the Todo App" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Todos");
        }
    }
}
