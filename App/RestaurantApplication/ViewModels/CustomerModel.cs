using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApplication.ViewModels
{
    public class CustomerModel
    {
        public int CustomerId { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerMiddleName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerUsername { get; set; }
        public string CustomerPassword { get; set; }
        public bool CustomerAccountStatus { get; set; }
    }
}
