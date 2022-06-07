using System.Collections.Generic;

#nullable disable

namespace RestaurantApplication.Domain.Models
{
    public partial class Dish
    {
        public Dish()
        {
            OrderDetails = new HashSet<OrderDetail>();
            Ratings = new HashSet<Rating>();
        }

        public int DishId { get; set; }
        public string DishName { get; set; }
        public double DishPrice { get; set; }
        public int MenuTypeId { get; set; }
        public string DishIngredients { get; set; }
        public bool DishStatus { get; set; }
        public string DishWeight { get; set; }

        public virtual MenuType MenuType { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
