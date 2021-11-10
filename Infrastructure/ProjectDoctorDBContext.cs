using Microsoft.EntityFrameworkCore;
using Spg.ProjecctDoctor.Backend.Models;
using Spg.ProjectDoctor.Backend.Domain;
using Spg.ProjectDoctor.Backend.Domain.Models;
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
    }

}
