using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaktabTaha.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initReqConvReq : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InitialRequest");

            migrationBuilder.CreateTable(
                name: "Request",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestTypeId = table.Column<int>(type: "int", nullable: false),
                    ClientFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HouseHeadStatusId = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefererId = table.Column<int>(type: "int", nullable: false),
                    NationaltyId = table.Column<int>(type: "int", nullable: false),
                    ProvinceId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AreaId = table.Column<int>(type: "int", nullable: false),
                    ReligonId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApproveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OfficerDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Attachment = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Request", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Request_Area_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Area",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Request_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Request_Donor_RefererId",
                        column: x => x.RefererId,
                        principalTable: "Donor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Request_HouseHeadStatus_HouseHeadStatusId",
                        column: x => x.HouseHeadStatusId,
                        principalTable: "HouseHeadStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Request_Province_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Province",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Request_Religon_ReligonId",
                        column: x => x.ReligonId,
                        principalTable: "Religon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Request_RequestType_RequestTypeId",
                        column: x => x.RequestTypeId,
                        principalTable: "RequestType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Request_nationality_NationaltyId",
                        column: x => x.NationaltyId,
                        principalTable: "nationality",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Request_AreaId",
                table: "Request",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Request_CityId",
                table: "Request",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Request_HouseHeadStatusId",
                table: "Request",
                column: "HouseHeadStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Request_NationaltyId",
                table: "Request",
                column: "NationaltyId");

            migrationBuilder.CreateIndex(
                name: "IX_Request_ProvinceId",
                table: "Request",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Request_RefererId",
                table: "Request",
                column: "RefererId");

            migrationBuilder.CreateIndex(
                name: "IX_Request_ReligonId",
                table: "Request",
                column: "ReligonId");

            migrationBuilder.CreateIndex(
                name: "IX_Request_RequestTypeId",
                table: "Request",
                column: "RequestTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Request");

            migrationBuilder.CreateTable(
                name: "InitialRequest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    HouseHeadStatusId = table.Column<int>(type: "int", nullable: false),
                    NationaltyId = table.Column<int>(type: "int", nullable: false),
                    ProvinceId = table.Column<int>(type: "int", nullable: false),
                    RefererId = table.Column<int>(type: "int", nullable: false),
                    ReligonId = table.Column<int>(type: "int", nullable: false),
                    RequestTypeId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApproveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Attachment = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ClientFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OfficerDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InitialRequest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InitialRequest_Area_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Area",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InitialRequest_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InitialRequest_Donor_RefererId",
                        column: x => x.RefererId,
                        principalTable: "Donor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InitialRequest_HouseHeadStatus_HouseHeadStatusId",
                        column: x => x.HouseHeadStatusId,
                        principalTable: "HouseHeadStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InitialRequest_Province_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Province",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InitialRequest_Religon_ReligonId",
                        column: x => x.ReligonId,
                        principalTable: "Religon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InitialRequest_RequestType_RequestTypeId",
                        column: x => x.RequestTypeId,
                        principalTable: "RequestType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InitialRequest_nationality_NationaltyId",
                        column: x => x.NationaltyId,
                        principalTable: "nationality",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InitialRequest_AreaId",
                table: "InitialRequest",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_InitialRequest_CityId",
                table: "InitialRequest",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_InitialRequest_HouseHeadStatusId",
                table: "InitialRequest",
                column: "HouseHeadStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_InitialRequest_NationaltyId",
                table: "InitialRequest",
                column: "NationaltyId");

            migrationBuilder.CreateIndex(
                name: "IX_InitialRequest_ProvinceId",
                table: "InitialRequest",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_InitialRequest_RefererId",
                table: "InitialRequest",
                column: "RefererId");

            migrationBuilder.CreateIndex(
                name: "IX_InitialRequest_ReligonId",
                table: "InitialRequest",
                column: "ReligonId");

            migrationBuilder.CreateIndex(
                name: "IX_InitialRequest_RequestTypeId",
                table: "InitialRequest",
                column: "RequestTypeId");
        }
    }
}
