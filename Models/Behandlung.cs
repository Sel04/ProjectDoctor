using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.ProjectDoctor.Backend.Domain.Models
{
    public class Behandlung
    {
        public string Id => $"{ArztId} + {PatientId}";
        public DateTime Beginn { get; set; }
        public DateTime Ende { get; set; }

        public string ArztId { get; set; } = string.Empty;
        public Arzt Arzt { get; set; } = null!;

        public string PatientId { get; set; } = string.Empty;
        public Patient Patient { get; set; } = null!;


    }
}
