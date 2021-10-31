using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.ProjectDoctor.Backend.Domain.Models
{
    public class AerzteKammer
    {
        public string Id { get; set; } = string.Empty;
        public string Leiter { get; set; } = string.Empty;
        public IEnumerable<Arzt> arzts = new List<Arzt>();
    }
}
