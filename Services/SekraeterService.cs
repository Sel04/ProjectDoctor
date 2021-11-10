using Spg.ProjecctDoctor.Backend.Infrastructure;
using Spg.ProjectDoctor.Backend.Domain.Models;
using Spg.ProjectDoctor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spg.ProjectDoctor.Services
{
    public class SekraeterService : ISektraeter
    {
        private ProjectDoctorDBContext _context;

        public SekraeterService(ProjectDoctorDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Sekraeter> GetAll()
        {
            return _context.Sekraeters.ToList();
        }

        public IEnumerable<Sekraeter> ListSekraeterByOrdination(string OrdinationId)
        {
            return _context.Sekraeters
                   .Where(s => s.OrdinationId == OrdinationId)
                   .ToList();
        }
    }
}
