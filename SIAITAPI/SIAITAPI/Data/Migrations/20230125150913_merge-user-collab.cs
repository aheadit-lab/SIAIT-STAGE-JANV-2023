using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIAITAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class mergeusercollab : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Career_Category_CategoryId",
                table: "Career");

            migrationBuilder.DropForeignKey(
                name: "FK_Career_Civil_Status_CivilStatusId",
                table: "Career");

            migrationBuilder.DropForeignKey(
                name: "FK_Career_Grade_GradeId",
                table: "Career");

            migrationBuilder.DropForeignKey(
                name: "FK_Career_Qualification_QualificationId",
                table: "Career");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.RenameColumn(
                name: "QualificationId",
                table: "Qualification",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "GradeId",
                table: "Grade",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Collaborator",
                newName: "ProfilId");

            migrationBuilder.RenameColumn(
                name: "CivilStatusId",
                table: "Civil_Status",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Category",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Collaborator",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "SuperUser",
                table: "Collaborator",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Collaborator",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Collaborator_ProfilId",
                table: "Collaborator",
                column: "ProfilId");

            migrationBuilder.AddForeignKey(
                name: "FK_Career_Category_CategoryId",
                table: "Career",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Career_Civil_Status_CivilStatusId",
                table: "Career",
                column: "CivilStatusId",
                principalTable: "Civil_Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Career_Grade_GradeId",
                table: "Career",
                column: "GradeId",
                principalTable: "Grade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Career_Qualification_QualificationId",
                table: "Career",
                column: "QualificationId",
                principalTable: "Qualification",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_Career_Category_CategoryId",
                table: "Career");

            migrationBuilder.DropForeignKey(
                name: "FK_Career_Civil_Status_CivilStatusId",
                table: "Career");

            migrationBuilder.DropForeignKey(
                name: "FK_Career_Grade_GradeId",
                table: "Career");

            migrationBuilder.DropForeignKey(
                name: "FK_Career_Qualification_QualificationId",
                table: "Career");

            migrationBuilder.DropForeignKey(
                name: "FK_Collaborator_Profil_ProfilId",
                table: "Collaborator");

            migrationBuilder.DropIndex(
                name: "IX_Collaborator_ProfilId",
                table: "Collaborator");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Collaborator");

            migrationBuilder.DropColumn(
                name: "SuperUser",
                table: "Collaborator");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Collaborator");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Qualification",
                newName: "QualificationId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Grade",
                newName: "GradeId");

            migrationBuilder.RenameColumn(
                name: "ProfilId",
                table: "Collaborator",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Civil_Status",
                newName: "CivilStatusId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Category",
                newName: "CategoryId");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CollaboratorId = table.Column<int>(type: "int", nullable: true),
                    ProfilId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuperUser = table.Column<bool>(type: "bit", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Collaborator_CollaboratorId",
                        column: x => x.CollaboratorId,
                        principalTable: "Collaborator",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_User_Profil_ProfilId",
                        column: x => x.ProfilId,
                        principalTable: "Profil",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_CollaboratorId",
                table: "User",
                column: "CollaboratorId",
                unique: true,
                filter: "[CollaboratorId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_User_ProfilId",
                table: "User",
                column: "ProfilId");

            migrationBuilder.AddForeignKey(
                name: "FK_Career_Category_CategoryId",
                table: "Career",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Career_Civil_Status_CivilStatusId",
                table: "Career",
                column: "CivilStatusId",
                principalTable: "Civil_Status",
                principalColumn: "CivilStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Career_Grade_GradeId",
                table: "Career",
                column: "GradeId",
                principalTable: "Grade",
                principalColumn: "GradeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Career_Qualification_QualificationId",
                table: "Career",
                column: "QualificationId",
                principalTable: "Qualification",
                principalColumn: "QualificationId");
        }
    }
}
