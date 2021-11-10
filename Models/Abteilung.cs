using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.ProjectDoctor.Backend.Domain
{
   public class Abteilung
   {
        public string Kuerzel { get; set; }  //PK
        public int Id { get; set; }
        public NameRecord NameRecord { get; set; } = default!;

        public string KrankenhausId { get; set; } = string.Empty;
        public Krankenhaus Krankenhaus { get; set; } = null!; // Referenz zum Krankenhaus
        public IEnumerable<Arzt> Aerzte { get; set; } = new List<Arzt>();
   }
}
