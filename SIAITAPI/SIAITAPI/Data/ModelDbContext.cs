using Microsoft.EntityFrameworkCore;
using SIAITAPI.DTO;
using SIAITAPI.Models;
using Action = SIAITAPI.Models.Action;

namespace SIAITAPI.Data
{
    public class ModelDbContext : DbContext
    {
        public ModelDbContext(DbContextOptions<ModelDbContext> options)
             :base(options)
        {

        }
        
        public DbSet<Action>? Action { get; set; }
        public DbSet<Career> Career { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<CivilStatus> Civil_Status { get; set; }
        public DbSet<Collaborator> Collaborator { get; set; }
        public DbSet<Entity> Entity { get; set; }
        public DbSet<Grade> Grade { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Module> Module { get; set; }
        public DbSet<Profil>Profil { get; set; }
        public DbSet<ProfilAction> Profil_Action { get; set; }
        public DbSet<ProfilMenu> Profil_Menu { get; set; }
        public DbSet<Qualification> Qualification { get; set; }
        public DbSet<Project> Project { get; set; }
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

           

            modelBuilder.Entity<Career>()
                   .HasOne(e => e.Grade)
                   .WithMany(e => e.Career)
                   .HasForeignKey(e => e.GradeId);

        

            modelBuilder.Entity<Career>()
                   .HasOne(e => e.Category)
                   .WithMany(e => e.Career)
                   .HasForeignKey(e => e.CategoryId);

            modelBuilder.Entity<Career>()
                   .HasOne(e => e.CivilStatus)
                   .WithMany(e => e.Career)
                   .HasForeignKey(e => e.CivilStatusId);


            modelBuilder.Entity<Career>()
                   .HasOne(e => e.Qualification)
                   .WithMany(e => e.Career)
                   .HasForeignKey(e => e.QualificationId);
                  


            modelBuilder.Entity<Career>()
                   .HasOne(e => e.Collaborator)
                   .WithMany(e => e.Career)
                   .HasForeignKey(e => e.CollaboratorId)
                   .OnDelete(DeleteBehavior.Cascade);



            modelBuilder.Entity<Collaborator>()
                   .HasOne(e => e.Grade)
                   .WithMany(e => e.Collaborator)
                   .HasForeignKey(e => e.GradeId);



            modelBuilder.Entity<Collaborator>()
                   .HasOne(e => e.Category)
                   .WithMany(e => e.Collaborator)
                   .HasForeignKey(e => e.CategoryId);


            modelBuilder.Entity<Collaborator>()
                   .HasOne(e => e.CivilStatus)
                   .WithMany(e => e.Collaborator)
                   .HasForeignKey(e => e.CivilStatusId);


            modelBuilder.Entity<Collaborator>()
                   .HasOne(e => e.Qualification)
                   .WithMany(e => e.Collaborator)
                   .HasForeignKey(e => e.QualificationId);


            modelBuilder.Entity<Collaborator>()
                   .HasOne(e => e.Profil)
                   .WithMany(e => e.Collaborator)
                   .HasForeignKey(e => e.ProfilId);
                  



            

            modelBuilder.Entity<ProfilAction>()
                .HasOne(bc => bc.Profil)
                .WithMany(b => b.ProfilAction)
                .HasForeignKey(bc => bc.ProfilId)  
                 .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<ProfilAction>()
                .HasOne(bc => bc.Action)
                .WithMany(c => c.ProfilAction)
                .HasForeignKey(bc => bc.ActionId)
                 .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<ProfilMenu>()
               .HasOne(bc => bc.Profil)
               .WithMany(b => b.ProfilMenu)
               .HasForeignKey(bc => bc.ProfilId)
                .OnDelete(DeleteBehavior.Cascade); 

            modelBuilder.Entity<ProfilMenu>()
                .HasOne(bc => bc.Menu)
                .WithMany(c => c.ProfilMenu)
                .HasForeignKey(bc => bc.MenuId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Menu>()
                   .HasOne(e => e.Module)
                   .WithMany(e => e.Menu)
                   .HasForeignKey(e => e.ModuleId)
                   .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Project>()
                  .HasOne(e => e.Manager)
                  .WithMany(e => e.Project)
                  .HasForeignKey(e => e.ManagerId)
                  .OnDelete(DeleteBehavior.Cascade);



        }


    }
}
