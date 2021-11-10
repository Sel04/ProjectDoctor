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
    public class ArztService:IArztService
    {
        private ProjectDoctorDBContext _context;

        public ArztService(ProjectDoctorDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Arzt> GetAll()
        {
            return _context.Arzts
                .ToList();
        }

        public IEnumerable<Arzt> GetAllArztByAbteilung(string abteilung_kuerzel)
        {
            return _context.Arzts
                 .Where(s => s.AbteilungId == abteilung_kuerzel)
                 .ToList();
        }

        public IEnumerable<Arzt> GetAllArztByOrdination(string ordination_kuerzel)
        {
            return _context.Arzts
                .Where(s => s.OrdinationId == ordination_kuerzel)
                .ToList();
        }
    }
}
