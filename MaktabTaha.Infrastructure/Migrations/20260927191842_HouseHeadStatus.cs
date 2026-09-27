using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaktabTaha.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class HouseHeadStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InitialRequest_HouseHeadStatusDesc_HouseHeadStatusId",
                table: "InitialRequest");

            migrationBuilder.DropTable(
                name: "HouseHeadStatusDesc");

            migrationBuilder.AddColumn<int>(
                name: "HHType",
                table: "HouseHeadStatu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_InitialRequest_HouseHeadStatu_HouseHeadStatusId",
                table: "InitialRequest",
                column: "HouseHeadStatusId",
                principalTable: "HouseHeadStatu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InitialRequest_HouseHeadStatu_HouseHeadStatusId",
                table: "InitialRequest");

            migrationBuilder.DropColumn(
                name: "HHType",
                table: "HouseHeadStatu");

            migrationBuilder.CreateTable(
                name: "HouseHeadStatusDesc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HouseHeadStatusId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseHeadStatusDesc", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HouseHeadStatusDesc_HouseHeadStatu_HouseHeadStatusId",
                        column: x => x.HouseHeadStatusId,
                        principalTable: "HouseHeadStatu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HouseHeadStatusDesc_HouseHeadStatusId",
                table: "HouseHeadStatusDesc",
                column: "HouseHeadStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_InitialRequest_HouseHeadStatusDesc_HouseHeadStatusId",
                table: "InitialRequest",
                column: "HouseHeadStatusId",
                principalTable: "HouseHeadStatusDesc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
