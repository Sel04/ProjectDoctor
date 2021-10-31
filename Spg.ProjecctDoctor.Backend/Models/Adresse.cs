using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.ProjectDoctor.Backend.Domain
{
    public record Adresse
    {
        public string Postleitzahl { get; init; } = string.Empty;
        public string Strasse { get; init; } = string.Empty;
        public string HausNr { get; init; } = string.Empty;
    }
}
