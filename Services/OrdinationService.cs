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
    public class OrdinationService : IOrdinationService
    {
        private ProjectDoctorDBContext _context;

        public OrdinationService(ProjectDoctorDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Ordination> GetAll()
        {
            return _context.Ordinations
                .ToList();
        }

        public IEnumerable<Ordination> GetAllWithManager()
        {
            return _context.Ordinations
                .Include(s => s.Manager)
                .ToList();
        }
    }
}
