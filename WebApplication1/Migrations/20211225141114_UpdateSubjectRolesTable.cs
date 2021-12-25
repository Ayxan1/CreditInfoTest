using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class UpdateSubjectRolesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubjectRoles_Currencies_CurrencyId",
                table: "SubjectRoles");

            migrationBuilder.AlterColumn<int>(
                name: "CurrencyId",
                table: "SubjectRoles",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectRoles_Currencies_CurrencyId",
                table: "SubjectRoles",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubjectRoles_Currencies_CurrencyId",
                table: "SubjectRoles");

            migrationBuilder.AlterColumn<int>(
                name: "CurrencyId",
                table: "SubjectRoles",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectRoles_Currencies_CurrencyId",
                table: "SubjectRoles",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
