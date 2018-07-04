using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AngularASPNETCore2WebApiAuth.Migrations
{
    public partial class CreatTableTblMasterTblDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblMasters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    EnteredBY = table.Column<int>(type: "int", nullable: false),
                    EnteredBYCustomerId = table.Column<int>(type: "int", nullable: true),
                    EnteredOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EquipmentLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateBY = table.Column<int>(type: "int", nullable: false),
                    LastUpdateBYCustomerId = table.Column<int>(type: "int", nullable: true),
                    LastUpdateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PurchasePrice = table.Column<double>(type: "float", nullable: false),
                    Purchased = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblMasters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblMasters_Customers_EnteredBYCustomerId",
                        column: x => x.EnteredBYCustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblMasters_Customers_LastUpdateBYCustomerId",
                        column: x => x.LastUpdateBYCustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActivityComplete = table.Column<bool>(type: "bit", nullable: false),
                    ActivityDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompletedBY = table.Column<int>(type: "int", nullable: false),
                    CompletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EnteredBY = table.Column<int>(type: "int", nullable: false),
                    EnteredBYCustomerId = table.Column<int>(type: "int", nullable: true),
                    EnteredOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EquipmentID = table.Column<int>(type: "int", nullable: false),
                    EquipmentIDTblMasterId = table.Column<int>(type: "int", nullable: true),
                    LastUpdateBYCustomerId = table.Column<int>(type: "int", nullable: true),
                    LastUpdatedBY = table.Column<int>(type: "int", nullable: false),
                    LastUpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblDetails_Customers_EnteredBYCustomerId",
                        column: x => x.EnteredBYCustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblDetails_TblMasters_EquipmentIDTblMasterId",
                        column: x => x.EquipmentIDTblMasterId,
                        principalTable: "TblMasters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblDetails_Customers_LastUpdateBYCustomerId",
                        column: x => x.LastUpdateBYCustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblDetails_EnteredBYCustomerId",
                table: "TblDetails",
                column: "EnteredBYCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_TblDetails_EquipmentIDTblMasterId",
                table: "TblDetails",
                column: "EquipmentIDTblMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_TblDetails_LastUpdateBYCustomerId",
                table: "TblDetails",
                column: "LastUpdateBYCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_TblMasters_EnteredBYCustomerId",
                table: "TblMasters",
                column: "EnteredBYCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_TblMasters_LastUpdateBYCustomerId",
                table: "TblMasters",
                column: "LastUpdateBYCustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblDetails");

            migrationBuilder.DropTable(
                name: "TblMasters");
        }
    }
}
