using Spg.ProjecctDoctor.Backend.Infrastructure;
using Spg.ProjecctDoctor.Backend.Interfaces;
using Spg.ProjectDoctor.Backend.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.ProjecctDoctor.Backend.Services
{
    public class AbteilungService:IAbteilungService
    {
        private ProjectDoctorDBContext _context;

        public AbteilungService(ProjectDoctorDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Abteilung> GetAbteilungenByKrankenhaus(string kuerzel)
        {
            return _context.Abteilungs
                .Where(s => s.KrankenhausId == kuerzel)
                .ToList();
        }

        public IEnumerable<Abteilung> GetAll()
        {
            return _context.Abteilungs
                .ToList();
        }
    }
}
