using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TelephoneDirectoryApi.Migrations
{
    public partial class AddedFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TelephoneDirectorys",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    SurName = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Company = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    CommunicationInformation = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    CommunicationType = table.Column<int>(type: "integer", nullable: true),
                    InformationContent = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Report = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelephoneDirectorys", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TelephoneDirectorys");
        }
    }
}
