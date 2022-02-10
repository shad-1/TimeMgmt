using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeMgmt.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "ToDos",
                columns: table => new
                {
                    TaskId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TaskName = table.Column<string>(nullable: false),
                    DueDate = table.Column<string>(nullable: true),
                    Quadrant = table.Column<int>(nullable: false),
                    Categoryid = table.Column<int>(nullable: false),
                    Completed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDos", x => x.TaskId);
                    table.ForeignKey(
                        name: "FK_ToDos_Categories_Categoryid",
                        column: x => x.Categoryid,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 1, "Home" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 2, "School" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 3, "Work" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 4, "Church" });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "TaskId", "Categoryid", "Completed", "DueDate", "Quadrant", "TaskName" },
                values: new object[] { 1, 2, false, "2022-02-09", 3, "Project 1" });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "TaskId", "Categoryid", "Completed", "DueDate", "Quadrant", "TaskName" },
                values: new object[] { 2, 2, false, "2022-02-10", 3, "HBGary Analysis" });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "TaskId", "Categoryid", "Completed", "DueDate", "Quadrant", "TaskName" },
                values: new object[] { 3, 2, false, "2022-02-09", 3, "MLR" });

            migrationBuilder.CreateIndex(
                name: "IX_ToDos_Categoryid",
                table: "ToDos",
                column: "Categoryid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToDos");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
