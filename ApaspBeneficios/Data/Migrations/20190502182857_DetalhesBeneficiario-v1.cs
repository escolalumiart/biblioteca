using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EscolaLumiart.Data.Migrations
{
    public partial class DetalhesBeneficiariov1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "None",
                table: "Depedentes",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "None",
                table: "Beneficiarios",
                newName: "Nome");

            migrationBuilder.AddColumn<string>(
                name: "Cpf",
                table: "Depedentes",
                maxLength: 13,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataExclusao",
                table: "Depedentes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataInclusao",
                table: "Depedentes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "Depedentes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Beneficiarios",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CEP",
                table: "Beneficiarios",
                maxLength: 9,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Celular",
                table: "Beneficiarios",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Beneficiarios",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Complemento",
                table: "Beneficiarios",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cpf",
                table: "Beneficiarios",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataExclusao",
                table: "Beneficiarios",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataInclusao",
                table: "Beneficiarios",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "Beneficiarios",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Beneficiarios",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Beneficiarios",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Beneficiarios",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UF",
                table: "Beneficiarios",
                maxLength: 2,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "Depedentes");

            migrationBuilder.DropColumn(
                name: "DataExclusao",
                table: "Depedentes");

            migrationBuilder.DropColumn(
                name: "DataInclusao",
                table: "Depedentes");

            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "Depedentes");

            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "Beneficiarios");

            migrationBuilder.DropColumn(
                name: "CEP",
                table: "Beneficiarios");

            migrationBuilder.DropColumn(
                name: "Celular",
                table: "Beneficiarios");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Beneficiarios");

            migrationBuilder.DropColumn(
                name: "Complemento",
                table: "Beneficiarios");

            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "Beneficiarios");

            migrationBuilder.DropColumn(
                name: "DataExclusao",
                table: "Beneficiarios");

            migrationBuilder.DropColumn(
                name: "DataInclusao",
                table: "Beneficiarios");

            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "Beneficiarios");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Beneficiarios");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "Beneficiarios");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Beneficiarios");

            migrationBuilder.DropColumn(
                name: "UF",
                table: "Beneficiarios");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Depedentes",
                newName: "None");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Beneficiarios",
                newName: "None");
        }
    }
}
