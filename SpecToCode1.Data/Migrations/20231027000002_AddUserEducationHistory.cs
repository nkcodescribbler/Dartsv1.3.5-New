using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpecToCode1.Data.Migrations
{
    public partial class AddUserEducationHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserEducationHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationType = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    InstitutionName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    InstitutionAddressLine1 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    InstitutionAddressLine2 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    InstitutionCity = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    InstitutionState = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    InstitutionPincode = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEducationHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserEducationHistory_Persons_UserId",
                        column: x => x.UserId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserEducationHistory_UserId",
                table: "UserEducationHistory",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserEducationHistory");
        }
    }
}