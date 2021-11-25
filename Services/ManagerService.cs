using Spg.ProjecctDoctor.Backend.Infrastructure;
using Spg.ProjectDoctor.Backend.Domain.Models;
using Spg.ProjectDoctor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spg.ProjectDoctor.Services
{
    public class ManagerService : IManager
    {
        private ProjectDoctorDBContext _context;

        public ManagerService(ProjectDoctorDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Manager> getAll()
        {
            return _context.Managers.ToList();
        }

        


       public IEnumerable<Manager> ListManagersByOrdination(string OrdiantionId)
        {
            return _context.Managers
                .Where(m => m.OrdinationId == OrdiantionId)
                .ToList();
        }

        
    }
}
