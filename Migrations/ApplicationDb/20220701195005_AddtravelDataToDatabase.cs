using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace logindemo.Migrations.ApplicationDb
{
    public partial class AddtravelDataToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "travelDatas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    placeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    audults = table.Column<int>(type: "int", nullable: false),
                    child = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: false),
                    days = table.Column<int>(type: "int", nullable: false),
                    night = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_travelDatas", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "travelDatas");
        }
    }
}
