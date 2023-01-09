using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Situationships.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedUserEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Interrests",
                table: "Users",
                newName: "Interests");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Interests",
                table: "Users",
                newName: "Interrests");
        }
    }
}
