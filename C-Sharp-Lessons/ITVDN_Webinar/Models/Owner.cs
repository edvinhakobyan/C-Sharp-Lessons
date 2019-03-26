using System;
using System.Collections.Generic;

namespace ITVDN_Webinar.Models
{
    public partial class Owner
    {
        public Owner()
        {
            Company = new HashSet<Company>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int CompanyId { get; set; }

        public Company CompanyNavigation { get; set; }
        public ICollection<Company> Company { get; set; }
    }
}
