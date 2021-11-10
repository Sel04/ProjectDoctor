using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.ProjectDoctor.Backend.Domain
{
    public record NameRecord
    {
        public string Firstname { get; init; } = "";
        public string Lastname { get; init; } = "";

    }
}
