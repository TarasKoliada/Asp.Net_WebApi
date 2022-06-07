using System;

#nullable disable

namespace RestaurantApplication.Domain.Models
{
    public partial class Rating
    {
        public int RatingId { get; set; }
        public int DishId { get; set; }
        public string Score { get; set; }
        public string Remarks { get; set; }
        public DateTime RecordedDate { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Dish Dish { get; set; }
    }
}
