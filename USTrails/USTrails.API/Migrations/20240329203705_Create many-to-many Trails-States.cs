using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace USTrails.API.Migrations
{
    /// <inheritdoc />
    public partial class CreatemanytomanyTrailsStates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trails_States_StateId",
                table: "Trails");

            migrationBuilder.DropIndex(
                name: "IX_Trails_StateId",
                table: "Trails");

            migrationBuilder.DropColumn(
                name: "StateId",
                table: "Trails");

            migrationBuilder.CreateTable(
                name: "StateTrail",
                columns: table => new
                {
                    StatesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrailsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateTrail", x => new { x.StatesId, x.TrailsId });
                    table.ForeignKey(
                        name: "FK_StateTrail_States_StatesId",
                        column: x => x.StatesId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StateTrail_Trails_TrailsId",
                        column: x => x.TrailsId,
                        principalTable: "Trails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StateTrail_TrailsId",
                table: "StateTrail",
                column: "TrailsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StateTrail");

            migrationBuilder.AddColumn<Guid>(
                name: "StateId",
                table: "Trails",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Trails_StateId",
                table: "Trails",
                column: "StateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trails_States_StateId",
                table: "Trails",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
