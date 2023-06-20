using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduHome.Migrations
{
    public partial class CorrectionFooter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstEmail",
                table: "GetInTouch");

            migrationBuilder.DropColumn(
                name: "FirstNumber",
                table: "GetInTouch");

            migrationBuilder.RenameColumn(
                name: "SecondNumber",
                table: "GetInTouch",
                newName: "Number");

            migrationBuilder.RenameColumn(
                name: "SecondEmail",
                table: "GetInTouch",
                newName: "Email");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Number",
                table: "GetInTouch",
                newName: "SecondNumber");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "GetInTouch",
                newName: "SecondEmail");

            migrationBuilder.AddColumn<string>(
                name: "FirstEmail",
                table: "GetInTouch",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstNumber",
                table: "GetInTouch",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
