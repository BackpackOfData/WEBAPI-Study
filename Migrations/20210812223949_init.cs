using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace another_test.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SupportReq",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(nullable: true),
                    FromWhoID = table.Column<int>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    DateExpired = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportReq", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SupportTakeReq",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupportReqID = table.Column<int>(nullable: false),
                    ReqStatus = table.Column<int>(nullable: true),
                    SupporterPresonID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportTakeReq", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SupportTakeReq_SupportReq_SupportReqID",
                        column: x => x.SupportReqID,
                        principalTable: "SupportReq",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SupportTakeReq_SupportReqID",
                table: "SupportTakeReq",
                column: "SupportReqID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SupportTakeReq");

            migrationBuilder.DropTable(
                name: "SupportReq");
        }
    }
}
