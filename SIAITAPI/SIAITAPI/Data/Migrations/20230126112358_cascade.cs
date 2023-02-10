using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIAITAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class cascade_old : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collaborator_Profil_ProfilId",
                table: "Collaborator");

            migrationBuilder.AddForeignKey(
                name: "FK_Collaborator_Profil_ProfilId",
                table: "Collaborator",
                column: "ProfilId",
                principalTable: "Profil",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collaborator_Profil_ProfilId",
                table: "Collaborator");

            migrationBuilder.AddForeignKey(
                name: "FK_Collaborator_Profil_ProfilId",
                table: "Collaborator",
                column: "ProfilId",
                principalTable: "Profil",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
