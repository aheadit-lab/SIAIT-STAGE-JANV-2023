// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SIAITAPI.Data;

#nullable disable

namespace SIAITAPI.Data.Migrations
{
    [DbContext(typeof(ModelDbContext))]
    [Migration("20230124133224_createdatabase")]
    partial class createdatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SIAITAPI.Models.Action", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("Mandatory")
                        .HasColumnType("bit");

                    b.Property<int?>("MenuId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("OnlySuperUser")
                        .HasColumnType("bit");

                    b.Property<string>("Options")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Urls")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.ToTable("Action");
                });

            modelBuilder.Entity("SIAITAPI.Models.Career", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bban")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("CivilStatusId")
                        .HasColumnType("int");

                    b.Property<int?>("CollaboratorId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("From")
                        .HasColumnType("datetime2");

                    b.Property<int?>("GradeId")
                        .HasColumnType("int");

                    b.Property<bool?>("HouseHolder")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.Property<int?>("NumberOfChildren")
                        .HasColumnType("int");

                    b.Property<int?>("QualificationId")
                        .HasColumnType("int");

                    b.Property<float?>("Salary")
                        .HasColumnType("real");

                    b.Property<DateTime?>("To")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CivilStatusId");

                    b.HasIndex("CollaboratorId");

                    b.HasIndex("GradeId");

                    b.HasIndex("QualificationId");

                    b.ToTable("Career");
                });

            modelBuilder.Entity("SIAITAPI.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("SIAITAPI.Models.CivilStatus", b =>
                {
                    b.Property<int>("CivilStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CivilStatusId"));

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("CivilStatusId");

                    b.ToTable("Civil_Status");
                });

            modelBuilder.Entity("SIAITAPI.Models.Collaborator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bban")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Cin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CivilStatusId")
                        .HasColumnType("int");

                    b.Property<string>("Cnss")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GradeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("HiringDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("HouseHolder")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("LeavesBalance")
                        .HasColumnType("real");

                    b.Property<DateTime?>("LeavesBalanceDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("NumberOfChildren")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QualificationId")
                        .HasColumnType("int");

                    b.Property<string>("RegistrationNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("Salary")
                        .HasColumnType("real");

                    b.Property<string>("Sex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CivilStatusId");

                    b.HasIndex("GradeId");

                    b.HasIndex("QualificationId");

                    b.ToTable("Collaborator");
                });

            modelBuilder.Entity("SIAITAPI.Models.Entity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployerCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExploitationCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RNE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SocialSecurityScheme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaxRegistrationNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TradeRegister")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Entity");
                });

            modelBuilder.Entity("SIAITAPI.Models.Grade", b =>
                {
                    b.Property<int>("GradeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GradeId"));

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("GradeId");

                    b.ToTable("Grade");
                });

            modelBuilder.Entity("SIAITAPI.Models.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Class")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ModuleId")
                        .HasColumnType("int");

                    b.Property<bool?>("OnlySuperUser")
                        .HasColumnType("bit");

                    b.Property<int?>("Order")
                        .HasColumnType("int");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ModuleId");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("SIAITAPI.Models.Module", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Class")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("OnlySuperUser")
                        .HasColumnType("bit");

                    b.Property<int?>("Order")
                        .HasColumnType("int");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Module");
                });

            modelBuilder.Entity("SIAITAPI.Models.Profil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Profil");
                });

            modelBuilder.Entity("SIAITAPI.Models.ProfilAction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ActionId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Options")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProfilId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ActionId");

                    b.HasIndex("ProfilId");

                    b.ToTable("Profil_Action");
                });

            modelBuilder.Entity("SIAITAPI.Models.ProfilMenu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MenuId")
                        .HasColumnType("int");

                    b.Property<int?>("ProfilId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.HasIndex("ProfilId");

                    b.ToTable("Profil_Menu");
                });

            modelBuilder.Entity("SIAITAPI.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<float?>("ConsumedDays")
                        .HasColumnType("real");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsExtern")
                        .HasColumnType("bit");

                    b.Property<int?>("ManagerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("NumberOfDays")
                        .HasColumnType("real");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ManagerId");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("SIAITAPI.Models.Qualification", b =>
                {
                    b.Property<int>("QualificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QualificationId"));

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("QualificationId");

                    b.ToTable("Qualification");
                });

            modelBuilder.Entity("SIAITAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CollaboratorId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProfilId")
                        .HasColumnType("int");

                    b.Property<bool?>("SuperUser")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CollaboratorId")
                        .IsUnique()
                        .HasFilter("[CollaboratorId] IS NOT NULL");

                    b.HasIndex("ProfilId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("SIAITAPI.Models.Action", b =>
                {
                    b.HasOne("SIAITAPI.Models.Menu", "Menu")
                        .WithMany("Action")
                        .HasForeignKey("MenuId");

                    b.Navigation("Menu");
                });

            modelBuilder.Entity("SIAITAPI.Models.Career", b =>
                {
                    b.HasOne("SIAITAPI.Models.Category", "Category")
                        .WithMany("Career")
                        .HasForeignKey("CategoryId");

                    b.HasOne("SIAITAPI.Models.CivilStatus", "CivilStatus")
                        .WithMany("Career")
                        .HasForeignKey("CivilStatusId");

                    b.HasOne("SIAITAPI.Models.Collaborator", "Collaborator")
                        .WithMany("Career")
                        .HasForeignKey("CollaboratorId");

                    b.HasOne("SIAITAPI.Models.Grade", "Grade")
                        .WithMany("Career")
                        .HasForeignKey("GradeId");

                    b.HasOne("SIAITAPI.Models.Qualification", "Qualification")
                        .WithMany("Career")
                        .HasForeignKey("QualificationId");

                    b.Navigation("Category");

                    b.Navigation("CivilStatus");

                    b.Navigation("Collaborator");

                    b.Navigation("Grade");

                    b.Navigation("Qualification");
                });

            modelBuilder.Entity("SIAITAPI.Models.Collaborator", b =>
                {
                    b.HasOne("SIAITAPI.Models.Category", "Category")
                        .WithMany("Collaborator")
                        .HasForeignKey("CategoryId");

                    b.HasOne("SIAITAPI.Models.CivilStatus", "CivilStatus")
                        .WithMany("Collaborator")
                        .HasForeignKey("CivilStatusId");

                    b.HasOne("SIAITAPI.Models.Grade", "Grade")
                        .WithMany("Collaborator")
                        .HasForeignKey("GradeId");

                    b.HasOne("SIAITAPI.Models.Qualification", "Qualification")
                        .WithMany("Collaborator")
                        .HasForeignKey("QualificationId");

                    b.Navigation("Category");

                    b.Navigation("CivilStatus");

                    b.Navigation("Grade");

                    b.Navigation("Qualification");
                });

            modelBuilder.Entity("SIAITAPI.Models.Menu", b =>
                {
                    b.HasOne("SIAITAPI.Models.Module", "Module")
                        .WithMany("Menu")
                        .HasForeignKey("ModuleId");

                    b.Navigation("Module");
                });

            modelBuilder.Entity("SIAITAPI.Models.ProfilAction", b =>
                {
                    b.HasOne("SIAITAPI.Models.Action", "Action")
                        .WithMany("ProfilAction")
                        .HasForeignKey("ActionId");

                    b.HasOne("SIAITAPI.Models.Profil", "Profil")
                        .WithMany("ProfilAction")
                        .HasForeignKey("ProfilId");

                    b.Navigation("Action");

                    b.Navigation("Profil");
                });

            modelBuilder.Entity("SIAITAPI.Models.ProfilMenu", b =>
                {
                    b.HasOne("SIAITAPI.Models.Menu", "Menu")
                        .WithMany("ProfilMenu")
                        .HasForeignKey("MenuId");

                    b.HasOne("SIAITAPI.Models.Profil", "Profil")
                        .WithMany("ProfilMenu")
                        .HasForeignKey("ProfilId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Menu");

                    b.Navigation("Profil");
                });

            modelBuilder.Entity("SIAITAPI.Models.Project", b =>
                {
                    b.HasOne("SIAITAPI.Models.Collaborator", "Manager")
                        .WithMany("Project")
                        .HasForeignKey("ManagerId");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("SIAITAPI.Models.User", b =>
                {
                    b.HasOne("SIAITAPI.Models.Collaborator", "Collaborator")
                        .WithOne("User")
                        .HasForeignKey("SIAITAPI.Models.User", "CollaboratorId");

                    b.HasOne("SIAITAPI.Models.Profil", "Profil")
                        .WithMany("User")
                        .HasForeignKey("ProfilId");

                    b.Navigation("Collaborator");

                    b.Navigation("Profil");
                });

            modelBuilder.Entity("SIAITAPI.Models.Action", b =>
                {
                    b.Navigation("ProfilAction");
                });

            modelBuilder.Entity("SIAITAPI.Models.Category", b =>
                {
                    b.Navigation("Career");

                    b.Navigation("Collaborator");
                });

            modelBuilder.Entity("SIAITAPI.Models.CivilStatus", b =>
                {
                    b.Navigation("Career");

                    b.Navigation("Collaborator");
                });

            modelBuilder.Entity("SIAITAPI.Models.Collaborator", b =>
                {
                    b.Navigation("Career");

                    b.Navigation("Project");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SIAITAPI.Models.Grade", b =>
                {
                    b.Navigation("Career");

                    b.Navigation("Collaborator");
                });

            modelBuilder.Entity("SIAITAPI.Models.Menu", b =>
                {
                    b.Navigation("Action");

                    b.Navigation("ProfilMenu");
                });

            modelBuilder.Entity("SIAITAPI.Models.Module", b =>
                {
                    b.Navigation("Menu");
                });

            modelBuilder.Entity("SIAITAPI.Models.Profil", b =>
                {
                    b.Navigation("ProfilAction");

                    b.Navigation("ProfilMenu");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SIAITAPI.Models.Qualification", b =>
                {
                    b.Navigation("Career");

                    b.Navigation("Collaborator");
                });
#pragma warning restore 612, 618
        }
    }
}
