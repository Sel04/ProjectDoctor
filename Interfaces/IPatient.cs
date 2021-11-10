using Spg.ProjectDoctor.Backend.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spg.ProjectDoctor.Interfaces
{
    public interface IPatient
    {
        IEnumerable<Patient> GetAll();

        IEnumerable<Patient> ListPatientByArzt(string ArztId);
      

    
    
}
}
