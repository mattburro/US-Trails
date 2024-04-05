using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace USTrails.API.Migrations
{
    /// <inheritdoc />
    public partial class removedifficultyandstateIDsfromtrailmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StateIds",
                table: "Trails");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StateIds",
                table: "Trails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
