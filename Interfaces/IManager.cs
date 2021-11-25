using Spg.ProjectDoctor.Backend.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spg.ProjectDoctor.Interfaces
{
    public interface IManager
    {
        IEnumerable<Manager> getAll();
       
        IEnumerable<Manager> ListManagersByOrdination(string OrdiantionId);
    }
}

