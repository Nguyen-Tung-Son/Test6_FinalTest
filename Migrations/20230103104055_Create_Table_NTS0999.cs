using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test6FinalTest.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableNTS0999 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NTS0999",
                columns: table => new
                {
                    NTSId = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    NTSName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    NTSGender = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NTS0999", x => x.NTSId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NTS0999");
        }
    }
}
