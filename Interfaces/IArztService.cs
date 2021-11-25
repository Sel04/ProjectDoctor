using Spg.ProjectDoctor.Backend.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.ProjecctDoctor.Backend.Interfaces
{
    public interface IArztService
    {
        IEnumerable<Arzt> GetAll();
        IEnumerable<Arzt> GetAllArztByAbteilung(string abteilung_kuerzel);
        IEnumerable<Arzt> GetAllArztByOrdination(string ordination_kuerzel);

        IEnumerable<Arzt> GetAllArztByAerzteKammer(string kammerId);
    }
}
