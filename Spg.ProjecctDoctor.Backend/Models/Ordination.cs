using Spg.ProjectDoctor.Backend.Domain.Models;
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
        public IEnumerable<Arzt> Aerzte { get; set; } = new List<Arzt>();
        public IEnumerable<Sekraeter> Sekraeters {get; set;} = new List<Sekraeter>();

        public string MangaerId { get; set; } = string.Empty;
        public Manager Manager { get; set; }
    }
}
