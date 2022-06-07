using Microsoft.EntityFrameworkCore;
using RestaurantApplication.BusinessLogic.Repositories.Interfaces;
using RestaurantApplication.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApplication.BusinessLogic.Repositories.Implementation
{
    public class OrderRepository : GenericRepository<Order>//IGenericRepository<Order>
    {
       // private readonly RestaurantDatabaseContext _context;
        public OrderRepository(RestaurantDatabaseContext context) : base(context)
        {
           // _context = context;
        }
        /*public bool Add(Order entity)
        {

            if (entity != null)
            {
                _context.Orders.Add(entity);
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var entity = Get(id);
            if (entity != null)
            {
                _context.Orders.Remove(entity);
                return true;
            }
            return false;
        }

        public Order Get(int id) => _context.Orders.FirstOrDefault(o => o.OrderId == id);

        public async Task<List<Order>> GetAllAsync() => await _context.Orders.ToListAsync();

        public async Task SaveDataAsync() => await _context.SaveChangesAsync();*/
    }
}
