using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace USTrails.API.Migrations
{
    /// <inheritdoc />
    public partial class AddstateIDstotrailmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StateIds",
                table: "Trails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StateIds",
                table: "Trails");
        }
    }
}
