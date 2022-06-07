using System.Collections.Generic;
using System;

#nullable disable

namespace RestaurantApplication.Domain.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
            Ratings = new HashSet<Rating>();
        }

        public int CustomerId { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerMiddleName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerUsername { get; set; }
        public string CustomerPassword { get; set; }
        public bool CustomerAccountStatus { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
