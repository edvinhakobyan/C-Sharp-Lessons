using System;
using System.Collections.Generic;

namespace ITVDN_Webinar.Models
{
    public partial class Humen
    {
        public Humen()
        {
            Company = new HashSet<Company>();
        }

        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Surname { get; set; }
        public int? Age { get; set; }

        public ICollection<Company> Company { get; set; }
    }
}
