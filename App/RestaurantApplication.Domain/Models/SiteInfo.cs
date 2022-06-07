using System;
using System.Collections.Generic;

#nullable disable

namespace RestaurantApplication.Domain.Models
{
    public partial class SiteInfo
    {
        public SiteInfo()
        {
            Administrators = new HashSet<Administrator>();
            Employees = new HashSet<Employee>();
            MenuTypes = new HashSet<MenuType>();
        }

        public int SiteId { get; set; }
        public string SiteName { get; set; }
        public string SiteDescription { get; set; }
        public string SiteContactInfo { get; set; }
        public string CompanyAdress { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual ICollection<Administrator> Administrators { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<MenuType> MenuTypes { get; set; }
    }
}
