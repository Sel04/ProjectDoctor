using Spg.ProjectDoctor.Backend.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.ProjecctDoctor.Backend.Interfaces
{
    public interface IOrdinationService
    {
        IEnumerable<Ordination> GetAll();

        IEnumerable<Ordination> GetAllWithManager();
    }
}
