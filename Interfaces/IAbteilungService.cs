using Spg.ProjectDoctor.Backend.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.ProjecctDoctor.Backend.Interfaces
{
    public interface IAbteilungService
    {
        IEnumerable<Abteilung> GetAll();
        IEnumerable<Abteilung> GetAbteilungenByKrankenhaus(string krankenhausId);
    }
}
