using System.Collections.Generic;

#nullable disable

namespace RestaurantApplication.Domain.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Orders = new HashSet<Order>();
            Payments = new HashSet<Payment>();
        }

        public int EmployeeId { get; set; }
        public int SiteId { get; set; }
        public string EmployeeSurname { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeMiddleName { get; set; }
        public string EmailAdress { get; set; }
        public string EmployeeContact { get; set; }
        public string SystemLogin { get; set; }
        public string SystemPassword { get; set; }
        public bool EmployeePreferences { get; set; }

        public virtual SiteInfo Site { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
