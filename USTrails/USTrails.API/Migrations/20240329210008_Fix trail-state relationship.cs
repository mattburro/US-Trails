using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace USTrails.API.Migrations
{
    /// <inheritdoc />
    public partial class Fixtrailstaterelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StateTrail_Trails_TrailsId",
                table: "StateTrail");

            migrationBuilder.RenameColumn(
                name: "TrailsId",
                table: "StateTrail",
                newName: "TrailId");

            migrationBuilder.RenameIndex(
                name: "IX_StateTrail_TrailsId",
                table: "StateTrail",
                newName: "IX_StateTrail_TrailId");

            migrationBuilder.AddForeignKey(
                name: "FK_StateTrail_Trails_TrailId",
                table: "StateTrail",
                column: "TrailId",
                principalTable: "Trails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StateTrail_Trails_TrailId",
                table: "StateTrail");

            migrationBuilder.RenameColumn(
                name: "TrailId",
                table: "StateTrail",
                newName: "TrailsId");

            migrationBuilder.RenameIndex(
                name: "IX_StateTrail_TrailId",
                table: "StateTrail",
                newName: "IX_StateTrail_TrailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_StateTrail_Trails_TrailsId",
                table: "StateTrail",
                column: "TrailsId",
                principalTable: "Trails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
