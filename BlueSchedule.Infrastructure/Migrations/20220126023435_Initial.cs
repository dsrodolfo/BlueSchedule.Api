using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlueSchedule.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    Responsible = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Description", "EndDate", "Responsible", "StartDate", "Title" },
                values: new object[] { new Guid("5c15c8da-20e1-436e-abb0-cf6152161751"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. \r\n                                    Lorem Ipsum has been the industry's standard dummy text ever since the 1500s", null, "Rodolfo Dias", new DateTime(2022, 1, 26, 2, 34, 35, 659, DateTimeKind.Utc).AddTicks(4776), "Test Item" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");
        }
    }
}
