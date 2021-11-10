using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.ProjectDoctor.Backend.Domain
{
    public enum Gender
    {
        M,
        W
    }
    public enum Position 
    { 
       aerztlicherDirektor,
       Assitenzarzt,
       Chefarzt,
       Famulus,
       Facharzt,
       Oberarzt,
       LeitenderOberarzt,
       PJStudent
    }
 
    public class Arzt
    {
        public string Kuerzel { get; set; } // PK
        public string Titel { get; set; } = string.Empty;
        public NameRecord NameRecord { get; set; } = default!;
        public Position Position { get; set; } 
        public Gender Gender { get; set; }
        public string Fach { get; set; } = string.Empty;
        public decimal Gehalt { get; set; }
        public string Telefonnummer { get; set; } = string.Empty;

        public string AbteilungId { get; set; } = string.Empty;
        public Abteilung Abteilung { get; set; } = null!;  // Referenz zur Abteilung
        public string OrdinationId { get; set; } = string.Empty;
        public Ordination Ordination { get; set; } = null!; // Referenz zur Ordination


    }
}
