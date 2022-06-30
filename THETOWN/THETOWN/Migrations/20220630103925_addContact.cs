using Microsoft.EntityFrameworkCore.Migrations;

namespace THETOWN.Migrations
{
    public partial class addContact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "contacts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true),
                    FirstIconUrl = table.Column<string>(nullable: true),
                    SecondIconUrl = table.Column<string>(nullable: true),
                    ThridIconUrl = table.Column<string>(nullable: true),
                    FirstIconText = table.Column<string>(nullable: true),
                    SecondIconText = table.Column<string>(nullable: true),
                    ThridIconText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contacts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contacts");
        }
    }
}
