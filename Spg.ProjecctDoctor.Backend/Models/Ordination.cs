using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.ProjectDoctor.Backend.Domain
{
    public class Ordination
    {
        public string Kuerzel { get; init; } = ""; //PK
        public string Telefonnummer { get; set; } = string.Empty;
        public NameRecord nameRecord { get; set; } = default!;
        public Adresse Adresse { get; set; } = default!;
        public IEnumerable<Arzt> aerzte { get; set; } = new List<Arzt>();
    }
}
