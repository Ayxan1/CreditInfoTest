using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class InitialVersionOfJoinsAmongTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IndividualId",
                table: "SubjectRoles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ContractId",
                table: "Individuals",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ContractId",
                table: "ContractDatas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SubjectRoles_IndividualId",
                table: "SubjectRoles",
                column: "IndividualId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Individuals_ContractId",
                table: "Individuals",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractDatas_ContractId",
                table: "ContractDatas",
                column: "ContractId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ContractDatas_Contracts_ContractId",
                table: "ContractDatas",
                column: "ContractId",
                principalTable: "Contracts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Individuals_Contracts_ContractId",
                table: "Individuals",
                column: "ContractId",
                principalTable: "Contracts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectRoles_Individuals_IndividualId",
                table: "SubjectRoles",
                column: "IndividualId",
                principalTable: "Individuals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContractDatas_Contracts_ContractId",
                table: "ContractDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_Individuals_Contracts_ContractId",
                table: "Individuals");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectRoles_Individuals_IndividualId",
                table: "SubjectRoles");

            migrationBuilder.DropIndex(
                name: "IX_SubjectRoles_IndividualId",
                table: "SubjectRoles");

            migrationBuilder.DropIndex(
                name: "IX_Individuals_ContractId",
                table: "Individuals");

            migrationBuilder.DropIndex(
                name: "IX_ContractDatas_ContractId",
                table: "ContractDatas");

            migrationBuilder.DropColumn(
                name: "IndividualId",
                table: "SubjectRoles");

            migrationBuilder.DropColumn(
                name: "ContractId",
                table: "Individuals");

            migrationBuilder.DropColumn(
                name: "ContractId",
                table: "ContractDatas");
        }
    }
}
