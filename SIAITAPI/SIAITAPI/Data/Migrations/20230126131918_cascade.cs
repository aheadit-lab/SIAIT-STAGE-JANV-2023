using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIAITAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class cascade : Migration
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
                name: "FK_Career_Collaborator_CollaboratorId",
                table: "Career");

            migrationBuilder.DropForeignKey(
                name: "FK_Career_Grade_GradeId",
                table: "Career");

            migrationBuilder.DropForeignKey(
                name: "FK_Career_Qualification_QualificationId",
                table: "Career");

            migrationBuilder.DropForeignKey(
                name: "FK_Menu_Module_ModuleId",
                table: "Menu");

            migrationBuilder.DropForeignKey(
                name: "FK_Profil_Action_Action_ActionId",
                table: "Profil_Action");

            migrationBuilder.DropForeignKey(
                name: "FK_Profil_Action_Profil_ProfilId",
                table: "Profil_Action");

            migrationBuilder.DropForeignKey(
                name: "FK_Profil_Menu_Menu_MenuId",
                table: "Profil_Menu");

            migrationBuilder.DropForeignKey(
                name: "FK_Project_Collaborator_ManagerId",
                table: "Project");

            migrationBuilder.AlterColumn<int>(
                name: "ProfilId",
                table: "Profil_Menu",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Career_Category_CategoryId",
                table: "Career",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Career_Civil_Status_CivilStatusId",
                table: "Career",
                column: "CivilStatusId",
                principalTable: "Civil_Status",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Career_Collaborator_CollaboratorId",
                table: "Career",
                column: "CollaboratorId",
                principalTable: "Collaborator",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Career_Grade_GradeId",
                table: "Career",
                column: "GradeId",
                principalTable: "Grade",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Career_Qualification_QualificationId",
                table: "Career",
                column: "QualificationId",
                principalTable: "Qualification",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Menu_Module_ModuleId",
                table: "Menu",
                column: "ModuleId",
                principalTable: "Module",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Profil_Action_Action_ActionId",
                table: "Profil_Action",
                column: "ActionId",
                principalTable: "Action",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Profil_Action_Profil_ProfilId",
                table: "Profil_Action",
                column: "ProfilId",
                principalTable: "Profil",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Profil_Menu_Menu_MenuId",
                table: "Profil_Menu",
                column: "MenuId",
                principalTable: "Menu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Collaborator_ManagerId",
                table: "Project",
                column: "ManagerId",
                principalTable: "Collaborator",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
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
                name: "FK_Career_Collaborator_CollaboratorId",
                table: "Career");

            migrationBuilder.DropForeignKey(
                name: "FK_Career_Grade_GradeId",
                table: "Career");

            migrationBuilder.DropForeignKey(
                name: "FK_Career_Qualification_QualificationId",
                table: "Career");

            migrationBuilder.DropForeignKey(
                name: "FK_Menu_Module_ModuleId",
                table: "Menu");

            migrationBuilder.DropForeignKey(
                name: "FK_Profil_Action_Action_ActionId",
                table: "Profil_Action");

            migrationBuilder.DropForeignKey(
                name: "FK_Profil_Action_Profil_ProfilId",
                table: "Profil_Action");

            migrationBuilder.DropForeignKey(
                name: "FK_Profil_Menu_Menu_MenuId",
                table: "Profil_Menu");

            migrationBuilder.DropForeignKey(
                name: "FK_Project_Collaborator_ManagerId",
                table: "Project");

            migrationBuilder.AlterColumn<int>(
                name: "ProfilId",
                table: "Profil_Menu",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
                name: "FK_Career_Collaborator_CollaboratorId",
                table: "Career",
                column: "CollaboratorId",
                principalTable: "Collaborator",
                principalColumn: "Id");

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
                name: "FK_Menu_Module_ModuleId",
                table: "Menu",
                column: "ModuleId",
                principalTable: "Module",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Profil_Action_Action_ActionId",
                table: "Profil_Action",
                column: "ActionId",
                principalTable: "Action",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Profil_Action_Profil_ProfilId",
                table: "Profil_Action",
                column: "ProfilId",
                principalTable: "Profil",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Profil_Menu_Menu_MenuId",
                table: "Profil_Menu",
                column: "MenuId",
                principalTable: "Menu",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Collaborator_ManagerId",
                table: "Project",
                column: "ManagerId",
                principalTable: "Collaborator",
                principalColumn: "Id");
        }
    }
}
