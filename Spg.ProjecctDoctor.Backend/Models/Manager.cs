using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.ProjectDoctor.Backend.Domain.Models
{
   
    public class Manager
    {
        public int Id { get; set; }
        public NameRecord NameRecord { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public int Old
        {
            get
            {
                return DateTime.Now.Year - BirthDate.Year;
            }
        }
        public string PhoneNumber { get; set; } = string.Empty;
        public Adresse Address { get; set; } = null!;
        public Gender Gender { get; set; }

    }
}
