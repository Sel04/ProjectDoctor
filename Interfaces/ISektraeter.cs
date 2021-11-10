using Spg.ProjectDoctor.Backend.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spg.ProjectDoctor.Interfaces
{
    public interface ISektraeter
    {
        IEnumerable<Sekraeter> GetAll();

        IEnumerable<Sekraeter> ListSekraeterByOrdination(string OrdinationId);
    }
}
