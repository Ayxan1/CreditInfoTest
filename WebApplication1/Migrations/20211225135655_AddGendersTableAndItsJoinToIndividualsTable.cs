using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WebApplication1.Migrations
{
    public partial class AddGendersTableAndItsJoinToIndividualsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Individuals");

            migrationBuilder.AddColumn<int>(
                name: "GenderId",
                table: "Individuals",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Individuals_GenderId",
                table: "Individuals",
                column: "GenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Individuals_Genders_GenderId",
                table: "Individuals",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Individuals_Genders_GenderId",
                table: "Individuals");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropIndex(
                name: "IX_Individuals_GenderId",
                table: "Individuals");

            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "Individuals");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Individuals",
                type: "text",
                nullable: true);
        }
    }
}
