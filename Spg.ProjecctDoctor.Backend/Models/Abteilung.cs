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
        public NameRecord nameRecord { get; set; } = default!;
        public Krankenhaus krankenhaus { get; set; } = null!; // Referenz zum Krankenhaus
        public IEnumerable<Arzt> aerzte { get; set; } = new List<Arzt>();
   }
}
