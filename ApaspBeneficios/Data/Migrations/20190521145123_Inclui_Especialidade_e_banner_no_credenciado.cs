using Microsoft.EntityFrameworkCore.Migrations;

namespace EscolaLumiart.Data.Migrations
{
    public partial class Inclui_Especialidade_e_banner_no_credenciado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Credenciados",
                table: "Credenciados");

            migrationBuilder.RenameTable(
                name: "Credenciados",
                newName: "Credenciados");

            migrationBuilder.AddColumn<string>(
                name: "Banner",
                table: "Credenciados",
                maxLength: 80,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Especialidade",
                table: "Credenciados",
                maxLength: 80,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Credenciados",
                table: "Credenciados",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Credenciados",
                table: "Credenciados");

            migrationBuilder.DropColumn(
                name: "Banner",
                table: "Credenciados");

            migrationBuilder.DropColumn(
                name: "Especialidade",
                table: "Credenciados");

            migrationBuilder.RenameTable(
                name: "Credenciados",
                newName: "Credenciado");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Credenciado",
                table: "Credenciado",
                column: "Id");
        }
    }
}
