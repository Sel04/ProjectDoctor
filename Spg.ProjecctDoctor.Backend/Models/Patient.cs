using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.ProjectDoctor.Backend.Domain.Models
{
    public enum Gender
    {
        Man,
        Woman,
        Other
    }
    public class Patient
    {
        public int Id { get; set; }
        public string SozialVersicherungnummer => $"{Versicherungsnummer} {BirthDate}";
        public NameRecord NameRecord { get; set; } = default!;
        public DateTime BirthDate { get; set; }
        public int Old { get {
                return DateTime.Now.Year - BirthDate.Year;  
            } 
        }
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public Gender Gender { get; set; }

        public string BehandlungId { get; set; } = string.Empty;
        public Behandlung Behandlung { get; set; } = null!;

        public string DiagnoseId { get; set; } = string.Empty;
        public Diagnose Diagnose { get; set; } = null!;

        public string Versicherungsnummer {get; set;}
    }



}
