using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WebApplication1.Migrations
{
    public partial class AddHelperTablesAndJoinsAmongTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Currency",
                table: "SubjectRoles");

            migrationBuilder.DropColumn(
                name: "RoleOfCustomer",
                table: "SubjectRoles");

            migrationBuilder.DropColumn(
                name: "Currency",
                table: "ContractDatas");

            migrationBuilder.DropColumn(
                name: "PhaseOfContract",
                table: "ContractDatas");

            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                table: "SubjectRoles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "SubjectRoles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                table: "ContractDatas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PhaseOfContractId",
                table: "ContractDatas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhaseOfContracts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhaseOfContracts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubjectRoles_CurrencyId",
                table: "SubjectRoles",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectRoles_RoleId",
                table: "SubjectRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractDatas_CurrencyId",
                table: "ContractDatas",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractDatas_PhaseOfContractId",
                table: "ContractDatas",
                column: "PhaseOfContractId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContractDatas_Currencies_CurrencyId",
                table: "ContractDatas",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContractDatas_PhaseOfContracts_PhaseOfContractId",
                table: "ContractDatas",
                column: "PhaseOfContractId",
                principalTable: "PhaseOfContracts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectRoles_Currencies_CurrencyId",
                table: "SubjectRoles",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectRoles_Roles_RoleId",
                table: "SubjectRoles",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContractDatas_Currencies_CurrencyId",
                table: "ContractDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_ContractDatas_PhaseOfContracts_PhaseOfContractId",
                table: "ContractDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectRoles_Currencies_CurrencyId",
                table: "SubjectRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectRoles_Roles_RoleId",
                table: "SubjectRoles");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "PhaseOfContracts");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_SubjectRoles_CurrencyId",
                table: "SubjectRoles");

            migrationBuilder.DropIndex(
                name: "IX_SubjectRoles_RoleId",
                table: "SubjectRoles");

            migrationBuilder.DropIndex(
                name: "IX_ContractDatas_CurrencyId",
                table: "ContractDatas");

            migrationBuilder.DropIndex(
                name: "IX_ContractDatas_PhaseOfContractId",
                table: "ContractDatas");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "SubjectRoles");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "SubjectRoles");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "ContractDatas");

            migrationBuilder.DropColumn(
                name: "PhaseOfContractId",
                table: "ContractDatas");

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "SubjectRoles",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RoleOfCustomer",
                table: "SubjectRoles",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "ContractDatas",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhaseOfContract",
                table: "ContractDatas",
                type: "text",
                nullable: true);
        }
    }
}
