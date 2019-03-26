using System;
using System.Collections.Generic;

namespace ITVDN_Webinar.Models
{
    public partial class Company
    {
        public Company()
        {
            OwnerNavigation = new HashSet<Owner>();
        }

        public int Id { get; set; }
        public string CompanyName { get; set; }
        public int? EmployCount { get; set; }
        public int? OwnerId { get; set; }
        public int? HumenId { get; set; }

        public Humen Humen { get; set; }
        public Owner Owner { get; set; }
        public ICollection<Owner> OwnerNavigation { get; set; }
    }
}
