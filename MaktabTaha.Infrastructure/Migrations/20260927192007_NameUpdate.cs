using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaktabTaha.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NameUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InitialRequest_HouseHeadStatu_HouseHeadStatusId",
                table: "InitialRequest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HousingStatu",
                table: "HousingStatu");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HouseHeadStatu",
                table: "HouseHeadStatu");

            migrationBuilder.RenameTable(
                name: "HousingStatu",
                newName: "HousingStatus");

            migrationBuilder.RenameTable(
                name: "HouseHeadStatu",
                newName: "HouseHeadStatus");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HousingStatus",
                table: "HousingStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HouseHeadStatus",
                table: "HouseHeadStatus",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InitialRequest_HouseHeadStatus_HouseHeadStatusId",
                table: "InitialRequest",
                column: "HouseHeadStatusId",
                principalTable: "HouseHeadStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InitialRequest_HouseHeadStatus_HouseHeadStatusId",
                table: "InitialRequest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HousingStatus",
                table: "HousingStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HouseHeadStatus",
                table: "HouseHeadStatus");

            migrationBuilder.RenameTable(
                name: "HousingStatus",
                newName: "HousingStatu");

            migrationBuilder.RenameTable(
                name: "HouseHeadStatus",
                newName: "HouseHeadStatu");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HousingStatu",
                table: "HousingStatu",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HouseHeadStatu",
                table: "HouseHeadStatu",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InitialRequest_HouseHeadStatu_HouseHeadStatusId",
                table: "InitialRequest",
                column: "HouseHeadStatusId",
                principalTable: "HouseHeadStatu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
