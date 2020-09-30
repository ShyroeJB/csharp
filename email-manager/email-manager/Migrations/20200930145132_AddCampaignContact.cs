using Microsoft.EntityFrameworkCore.Migrations;

namespace email_manager.Migrations
{
    public partial class AddCampaignContact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Campaign_Contact_ContactId",
                table: "Campaign");

            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Campaign_CampaignId",
                table: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Contact_CampaignId",
                table: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Campaign_ContactId",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "CampaignId",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "Campaign");

            migrationBuilder.CreateTable(
                name: "CampaignContact",
                columns: table => new
                {
                    CampaignId = table.Column<int>(nullable: false),
                    ContactId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignContact", x => new { x.CampaignId, x.ContactId });
                    table.ForeignKey(
                        name: "FK_CampaignContact_Campaign_CampaignId",
                        column: x => x.CampaignId,
                        principalTable: "Campaign",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampaignContact_Contact_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CampaignContact_ContactId",
                table: "CampaignContact",
                column: "ContactId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CampaignContact");

            migrationBuilder.AddColumn<int>(
                name: "CampaignId",
                table: "Contact",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContactId",
                table: "Campaign",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contact_CampaignId",
                table: "Contact",
                column: "CampaignId");

            migrationBuilder.CreateIndex(
                name: "IX_Campaign_ContactId",
                table: "Campaign",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Campaign_Contact_ContactId",
                table: "Campaign",
                column: "ContactId",
                principalTable: "Contact",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Campaign_CampaignId",
                table: "Contact",
                column: "CampaignId",
                principalTable: "Campaign",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
