using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaktabTaha.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TitleToNameAndCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Request_nationality_NationaltyId",
                table: "Request");

            migrationBuilder.DropPrimaryKey(
                name: "PK_nationality",
                table: "nationality");

            migrationBuilder.RenameTable(
                name: "nationality",
                newName: "Nationality");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "UnemploymentReason",
                newName: "UnemploymentReasonName");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Skill",
                newName: "SkillName");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "RequestType",
                newName: "RequestTypeName");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Religon",
                newName: "ReligonName");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Relation",
                newName: "RelationName");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Province",
                newName: "ProvinceName");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "PrivatenessStatus",
                newName: "PrivatenessStatusName");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "PhysicalStatus",
                newName: "PhysicalStatusName");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "OrphanStatus",
                newName: "OrphanStatusName");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Nationality",
                newName: "NationalityName");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Job",
                newName: "JobName");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "HousingStatus",
                newName: "HousingStatusName");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "HouseHeadStatus",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "GoodWorkType",
                newName: "GoodWorkTypeName");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "EmploymantStatus",
                newName: "EmploymentStatusName");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "EducationStatus",
                newName: "EducationStatusName");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "EducationLevel",
                newName: "EducationLevelName");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "City",
                newName: "CityName");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "CharityMainRole",
                newName: "CharityMainRoleName");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "CaseType",
                newName: "CaseTypeName");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Bank",
                newName: "BankName");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Area",
                newName: "AreaName");

            migrationBuilder.AddColumn<int>(
                name: "ProvinceCode",
                table: "Province",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CityCode",
                table: "City",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nationality",
                table: "Nationality",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Province_ProvinceCode",
                table: "Province",
                column: "ProvinceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_City_CityCode",
                table: "City",
                column: "CityCode",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Request_Nationality_NationaltyId",
                table: "Request",
                column: "NationaltyId",
                principalTable: "Nationality",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Request_Nationality_NationaltyId",
                table: "Request");

            migrationBuilder.DropIndex(
                name: "IX_Province_ProvinceCode",
                table: "Province");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Nationality",
                table: "Nationality");

            migrationBuilder.DropIndex(
                name: "IX_City_CityCode",
                table: "City");

            migrationBuilder.DropColumn(
                name: "ProvinceCode",
                table: "Province");

            migrationBuilder.DropColumn(
                name: "CityCode",
                table: "City");

            migrationBuilder.RenameTable(
                name: "Nationality",
                newName: "nationality");

            migrationBuilder.RenameColumn(
                name: "UnemploymentReasonName",
                table: "UnemploymentReason",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "SkillName",
                table: "Skill",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "RequestTypeName",
                table: "RequestType",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "ReligonName",
                table: "Religon",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "RelationName",
                table: "Relation",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "ProvinceName",
                table: "Province",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "PrivatenessStatusName",
                table: "PrivatenessStatus",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "PhysicalStatusName",
                table: "PhysicalStatus",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "OrphanStatusName",
                table: "OrphanStatus",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "NationalityName",
                table: "nationality",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "JobName",
                table: "Job",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "HousingStatusName",
                table: "HousingStatus",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "HouseHeadStatus",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "GoodWorkTypeName",
                table: "GoodWorkType",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "EmploymentStatusName",
                table: "EmploymantStatus",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "EducationStatusName",
                table: "EducationStatus",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "EducationLevelName",
                table: "EducationLevel",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "CityName",
                table: "City",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "CharityMainRoleName",
                table: "CharityMainRole",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "CaseTypeName",
                table: "CaseType",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "BankName",
                table: "Bank",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "AreaName",
                table: "Area",
                newName: "Title");

            migrationBuilder.AddPrimaryKey(
                name: "PK_nationality",
                table: "nationality",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Request_nationality_NationaltyId",
                table: "Request",
                column: "NationaltyId",
                principalTable: "nationality",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
