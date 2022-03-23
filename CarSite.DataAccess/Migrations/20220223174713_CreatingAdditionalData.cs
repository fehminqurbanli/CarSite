using Microsoft.EntityFrameworkCore.Migrations;

namespace CarSite.DataAccess.Migrations
{
    public partial class CreatingAdditionalData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City_Id",
                table: "TB_Ads");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "TB_Ads",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "TB_Ads",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "TB_Ads");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "TB_Ads");

            migrationBuilder.AddColumn<int>(
                name: "City_Id",
                table: "TB_Ads",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
