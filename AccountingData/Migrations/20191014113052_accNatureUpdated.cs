using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountingData.Migrations
{
    public partial class accNatureUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_AccountNatures_AccountNatureId",
                table: "Accounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccountNatures",
                table: "AccountNatures");

            migrationBuilder.RenameTable(
                name: "AccountNatures",
                newName: "AccountNature");

            migrationBuilder.AddColumn<string>(
                name: "AccountNature",
                table: "AccountTypes",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccountNature",
                table: "AccountNature",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_AccountNature_AccountNatureId",
                table: "Accounts",
                column: "AccountNatureId",
                principalTable: "AccountNature",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_AccountNature_AccountNatureId",
                table: "Accounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccountNature",
                table: "AccountNature");

            migrationBuilder.DropColumn(
                name: "AccountNature",
                table: "AccountTypes");

            migrationBuilder.RenameTable(
                name: "AccountNature",
                newName: "AccountNatures");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccountNatures",
                table: "AccountNatures",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_AccountNatures_AccountNatureId",
                table: "Accounts",
                column: "AccountNatureId",
                principalTable: "AccountNatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
