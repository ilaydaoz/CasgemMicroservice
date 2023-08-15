using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasgemMicroservice.Services.Cargo.DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CargoDetails_CargoStates_CargoStatesCargoStateID",
                table: "CargoDetails");

            migrationBuilder.AlterColumn<int>(
                name: "CargoStatesCargoStateID",
                table: "CargoDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_CargoDetails_CargoStates_CargoStatesCargoStateID",
                table: "CargoDetails",
                column: "CargoStatesCargoStateID",
                principalTable: "CargoStates",
                principalColumn: "CargoStateID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CargoDetails_CargoStates_CargoStatesCargoStateID",
                table: "CargoDetails");

            migrationBuilder.AlterColumn<int>(
                name: "CargoStatesCargoStateID",
                table: "CargoDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CargoDetails_CargoStates_CargoStatesCargoStateID",
                table: "CargoDetails",
                column: "CargoStatesCargoStateID",
                principalTable: "CargoStates",
                principalColumn: "CargoStateID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
