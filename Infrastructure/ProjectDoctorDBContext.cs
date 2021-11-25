using Microsoft.EntityFrameworkCore;
using Spg.ProjecctDoctor.Backend.Models;
using Spg.ProjectDoctor.Backend.Domain;
using Spg.ProjectDoctor.Backend.Domain.Models;
using Spg.ProjectDoctor.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.ProjecctDoctor.Backend.Infrastructure
{
    public class ProjectDoctorDBContext : DbContext
    {
        public ProjectDoctorDBContext()
        {

        }

        public ProjectDoctorDBContext(DbContextOptions options) 
            :base(options) 
        { }

        public DbSet<Abteilung> Abteilungs => Set<Abteilung>();
        public DbSet<AerzteKammer> AerzteKammers => Set<AerzteKammer>();
        public DbSet<Arzt> Arzts => Set<Arzt>();
        public DbSet<Behandlung> Behandlungs => Set<Behandlung>();
        public DbSet<Diagnose> Diagnoses => Set<Diagnose>();
        public DbSet<GeschaeftsFuerher> GeschaeftsFuerhers => Set<GeschaeftsFuerher>();
        public DbSet<Krankenhaus> Krankenhaus => Set<Krankenhaus>();
        public DbSet<Manager> Managers => Set<Manager>();
        public DbSet<Ordination> Ordinations => Set<Ordination>();
        public DbSet<Patient> Patients => Set<Patient>();
        public DbSet<Sekraeter> Sekraeters => Set<Sekraeter>(); 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Wenn dieser Context bwereits mit Options versehen wurde (Cunstructor)
            // wird dieser Block nicht ausgeführt.
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite(@"Data Source=ProjectDoctor.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuration

            modelBuilder.ApplyConfiguration(new AbteilungConfiguration());
            modelBuilder.ApplyConfiguration(new AerzteKammerConfigurationcs());
            modelBuilder.ApplyConfiguration(new ArztConfiguration());
            modelBuilder.ApplyConfiguration(new BehandlungConfiguration());
            modelBuilder.ApplyConfiguration(new GeschaeftsfuehrerConfiguration());
            modelBuilder.ApplyConfiguration(new KrankenhausConfiguration());
            modelBuilder.ApplyConfiguration(new ManagaerConfiguration());
            modelBuilder.ApplyConfiguration(new OrdinationConfiguration());
            modelBuilder.ApplyConfiguration(new PatientConfiguration());
            modelBuilder.ApplyConfiguration(new SekreaterConfiguration());



            // Relationships
            modelBuilder.Entity<Krankenhaus>().HasMany<Abteilung>(c => c.abteilungen);
            modelBuilder.Entity<Abteilung>().HasMany<Arzt>(c => c.Aerzte);
            modelBuilder.Entity<AerzteKammer>().HasMany<Arzt>(c => c.arzts);
            modelBuilder.Entity<Ordination>().HasMany<Arzt>(c => c.Aerzte);
            modelBuilder.Entity<Ordination>().HasMany<Manager>(c => c.Managers);
            modelBuilder.Entity<Ordination>().HasMany<Sekraeter>(c => c.Sekraeters);

            // Unique Constraints
            modelBuilder.Entity<AerzteKammer>().HasIndex(s => s.Id).IsUnique();
            modelBuilder.Entity<Arzt>().HasIndex(s => s.Telefonnummer).IsUnique();
            modelBuilder.Entity<Arzt>().HasIndex(s => s.Gender).IsUnique();
            modelBuilder.Entity<GeschaeftsFuerher>().HasIndex(s => s.PhoneNumber).IsUnique();
            modelBuilder.Entity<GeschaeftsFuerher>().HasIndex(s => s.Gender).IsUnique();
            modelBuilder.Entity<GeschaeftsFuerher>().HasIndex(s => s.BirthDate).IsUnique();
            modelBuilder.Entity<GeschaeftsFuerher>().HasIndex(s => s.Address).IsUnique();
            modelBuilder.Entity<Ordination>().HasIndex(s => s.Telefonnummer).IsUnique();
            modelBuilder.Entity<Ordination>().HasIndex(s => s.Adresse).IsUnique();
            modelBuilder.Entity<Patient>().HasIndex(s => s.SozialVersicherungnummer).IsUnique();
            modelBuilder.Entity<Patient>().HasIndex(s => s.PhoneNumber).IsUnique();
            modelBuilder.Entity<Patient>().HasIndex(s => s.Address).IsUnique();
            modelBuilder.Entity<Sekraeter>().HasIndex(s => s.PhoneNumber).IsUnique();
            modelBuilder.Entity<Sekraeter>().HasIndex(s => s.BirthDate).IsUnique();
            modelBuilder.Entity<Sekraeter>().HasIndex(s => s.Address).IsUnique();


        }

        


    }

}
