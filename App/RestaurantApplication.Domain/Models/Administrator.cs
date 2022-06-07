#nullable disable

namespace RestaurantApplication.Domain.Models
{
    public partial class Administrator
    {
        public int AdminId { get; set; }
        public int SiteId { get; set; }
        public string AdminName { get; set; }
        public string AdminSurname { get; set; }
        public string AdminMiddleName { get; set; }
        public string AdminLogin { get; set; }
        public string AdminPassword { get; set; }
        public string AdminContact { get; set; }
        public bool AdminPreferences { get; set; }

        public virtual SiteInfo Site { get; set; }
    }
}
