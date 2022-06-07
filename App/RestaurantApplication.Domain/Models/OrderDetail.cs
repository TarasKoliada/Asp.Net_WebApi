#nullable disable

namespace RestaurantApplication.Domain.Models
{
    public partial class OrderDetail
    {
        public int OrderDetailsId { get; set; }
        public int OrderId { get; set; }
        public int DishId { get; set; }
        public int NumberOdServings { get; set; }
        public double TotalDishPrice { get; set; }
        public string Note { get; set; }

        public virtual Dish Dish { get; set; }
        public virtual Order Order { get; set; }
    }
}
