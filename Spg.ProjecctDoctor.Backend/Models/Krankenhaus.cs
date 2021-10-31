using Spg.ProjecctDoctor.Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.ProjectDoctor.Backend.Domain
{
    public class Krankenhaus
    {
        public string Kuerzel { get; set; }  // PK
        public int Id { get; set; }  // Id Nummer
        public NameRecord nameRecord { get; set; } = default!; // Name des Krankenhauses
        public Adresse Adresse { get; set; } = default!;
        public IEnumerable<Abteilung> abteilungen { get; set; } = new List<Abteilung>(); //Liste von Abteilungen

        public string GeschaeftsFuerherId { get; set; } = string.Empty;
        public GeschaeftsFuerher GeschaeftsFuerher { get; set; } = null!;



    }
}
