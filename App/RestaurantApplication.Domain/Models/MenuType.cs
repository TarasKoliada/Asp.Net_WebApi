using System.Collections.Generic;

#nullable disable

namespace RestaurantApplication.Domain.Models
{
    public partial class MenuType
    {
        public MenuType()
        {
            Dishes = new HashSet<Dish>();
        }

        public int MenuTypeId { get; set; }
        public string MenuTypeName { get; set; }
        public string TypeDescription { get; set; }
        public int SiteId { get; set; }

        public virtual SiteInfo Site { get; set; }
        public virtual ICollection<Dish> Dishes { get; set; }
    }
}
