using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountingData.Migrations
{
    public partial class account_table_updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_AccountNature_AccountNatureId",
                table: "Accounts");

            migrationBuilder.DropTable(
                name: "AccountNature");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_AccountNatureId",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "AccountNatureId",
                table: "Accounts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccountNatureId",
                table: "Accounts",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AccountNature",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccountNatureName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountNature", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_AccountNatureId",
                table: "Accounts",
                column: "AccountNatureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_AccountNature_AccountNatureId",
                table: "Accounts",
                column: "AccountNatureId",
                principalTable: "AccountNature",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
