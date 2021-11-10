using Spg.ProjecctDoctor.Backend.Infrastructure;
using Spg.ProjectDoctor.Backend.Domain.Models;
using Spg.ProjectDoctor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spg.ProjectDoctor.Services
{
    public class PatientService: IPatient
    {
        private ProjectDoctorDBContext _context;

        public PatientService(ProjectDoctorDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Patient> GetAll()
        {
            return _context.Patients.ToList();
        }

        public IEnumerable<Patient> ListPatientByArzt(string ArztId)
        {
            return _context.Patients
                  .Where(p => p.Behandlung.ArztId == ArztId)
                  .ToList();
        }
    }
}
