using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIAITAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class createdatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Civil_Status",
                columns: table => new
                {
                    CivilStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Civil_Status", x => x.CivilStatusId);
                });

            migrationBuilder.CreateTable(
                name: "Entity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxRegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TradeRegister = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExploitationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployerCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialSecurityScheme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RNE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grade",
                columns: table => new
                {
                    GradeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grade", x => x.GradeId);
                });

            migrationBuilder.CreateTable(
                name: "Module",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    OnlySuperUser = table.Column<bool>(type: "bit", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Module", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profil",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profil", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Qualification",
                columns: table => new
                {
                    QualificationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qualification", x => x.QualificationId);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OnlySuperUser = table.Column<bool>(type: "bit", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModuleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menu_Module_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Module",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Collaborator",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bban = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    Cin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CivilStatusId = table.Column<int>(type: "int", nullable: true),
                    Cnss = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GradeId = table.Column<int>(type: "int", nullable: true),
                    HiringDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HouseHolder = table.Column<bool>(type: "bit", nullable: true),
                    LeavesBalance = table.Column<float>(type: "real", nullable: true),
                    LeavesBalanceDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NumberOfChildren = table.Column<int>(type: "int", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QualificationId = table.Column<int>(type: "int", nullable: true),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<float>(type: "real", nullable: true),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collaborator", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Collaborator_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId");
                    table.ForeignKey(
                        name: "FK_Collaborator_Civil_Status_CivilStatusId",
                        column: x => x.CivilStatusId,
                        principalTable: "Civil_Status",
                        principalColumn: "CivilStatusId");
                    table.ForeignKey(
                        name: "FK_Collaborator_Grade_GradeId",
                        column: x => x.GradeId,
                        principalTable: "Grade",
                        principalColumn: "GradeId");
                    table.ForeignKey(
                        name: "FK_Collaborator_Qualification_QualificationId",
                        column: x => x.QualificationId,
                        principalTable: "Qualification",
                        principalColumn: "QualificationId");
                });

            migrationBuilder.CreateTable(
                name: "Action",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Urls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mandatory = table.Column<bool>(type: "bit", nullable: true),
                    Options = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OnlySuperUser = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MenuId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Action", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Action_Menu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Profil_Menu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfilId = table.Column<int>(type: "int", nullable: false),
                    MenuId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profil_Menu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Profil_Menu_Menu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Profil_Menu_Profil_ProfilId",
                        column: x => x.ProfilId,
                        principalTable: "Profil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Career",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HouseHolder = table.Column<bool>(type: "bit", nullable: false),
                    Salary = table.Column<float>(type: "real", nullable: true),
                    Bban = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfChildren = table.Column<int>(type: "int", nullable: true),
                    From = table.Column<DateTime>(type: "datetime2", nullable: true),
                    To = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    CivilStatusId = table.Column<int>(type: "int", nullable: true),
                    CollaboratorId = table.Column<int>(type: "int", nullable: true),
                    GradeId = table.Column<int>(type: "int", nullable: true),
                    QualificationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Career", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Career_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId");
                    table.ForeignKey(
                        name: "FK_Career_Civil_Status_CivilStatusId",
                        column: x => x.CivilStatusId,
                        principalTable: "Civil_Status",
                        principalColumn: "CivilStatusId");
                    table.ForeignKey(
                        name: "FK_Career_Collaborator_CollaboratorId",
                        column: x => x.CollaboratorId,
                        principalTable: "Collaborator",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Career_Grade_GradeId",
                        column: x => x.GradeId,
                        principalTable: "Grade",
                        principalColumn: "GradeId");
                    table.ForeignKey(
                        name: "FK_Career_Qualification_QualificationId",
                        column: x => x.QualificationId,
                        principalTable: "Qualification",
                        principalColumn: "QualificationId");
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfDays = table.Column<float>(type: "real", nullable: true),
                    ConsumedDays = table.Column<float>(type: "real", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    IsExtern = table.Column<bool>(type: "bit", nullable: true),
                    ManagerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Project_Collaborator_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Collaborator",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CollaboratorId = table.Column<int>(type: "int", nullable: true),
                    SuperUser = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProfilId = table.Column<int>(type: "int", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "Profil_Action",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Options = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActionId = table.Column<int>(type: "int", nullable: true),
                    ProfilId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profil_Action", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Profil_Action_Action_ActionId",
                        column: x => x.ActionId,
                        principalTable: "Action",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Profil_Action_Profil_ProfilId",
                        column: x => x.ProfilId,
                        principalTable: "Profil",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Action_MenuId",
                table: "Action",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Career_CategoryId",
                table: "Career",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Career_CivilStatusId",
                table: "Career",
                column: "CivilStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Career_CollaboratorId",
                table: "Career",
                column: "CollaboratorId");

            migrationBuilder.CreateIndex(
                name: "IX_Career_GradeId",
                table: "Career",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_Career_QualificationId",
                table: "Career",
                column: "QualificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Collaborator_CategoryId",
                table: "Collaborator",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Collaborator_CivilStatusId",
                table: "Collaborator",
                column: "CivilStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Collaborator_GradeId",
                table: "Collaborator",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_Collaborator_QualificationId",
                table: "Collaborator",
                column: "QualificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_ModuleId",
                table: "Menu",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Profil_Action_ActionId",
                table: "Profil_Action",
                column: "ActionId");

            migrationBuilder.CreateIndex(
                name: "IX_Profil_Action_ProfilId",
                table: "Profil_Action",
                column: "ProfilId");

            migrationBuilder.CreateIndex(
                name: "IX_Profil_Menu_MenuId",
                table: "Profil_Menu",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Profil_Menu_ProfilId",
                table: "Profil_Menu",
                column: "ProfilId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_ManagerId",
                table: "Project",
                column: "ManagerId");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Career");

            migrationBuilder.DropTable(
                name: "Entity");

            migrationBuilder.DropTable(
                name: "Profil_Action");

            migrationBuilder.DropTable(
                name: "Profil_Menu");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Action");

            migrationBuilder.DropTable(
                name: "Collaborator");

            migrationBuilder.DropTable(
                name: "Profil");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Civil_Status");

            migrationBuilder.DropTable(
                name: "Grade");

            migrationBuilder.DropTable(
                name: "Qualification");

            migrationBuilder.DropTable(
                name: "Module");
        }
    }
}
