using System;

#nullable disable

namespace RestaurantApplication.Domain.Models
{
    public partial class Payment
    {
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        public double Price { get; set; }
        public string PaidBy { get; set; }
        public DateTime PaymentDate { get; set; }
        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Order Order { get; set; }
    }
}
