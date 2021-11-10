using Microsoft.EntityFrameworkCore;
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
    public class KrankenhausService : IKrankenhausService
    {
        private ProjectDoctorDBContext _context;

        public KrankenhausService(ProjectDoctorDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Krankenhaus> GetAll()
        {
            return _context.Krankenhaus
                .ToList();
        }

        public IEnumerable<Krankenhaus> GetAllWithgeschäftsfuehrer()
        {
            return _context.Krankenhaus
                .Include(s => s.GeschaeftsFuerher)
                .ToList();
        }
    }
}
