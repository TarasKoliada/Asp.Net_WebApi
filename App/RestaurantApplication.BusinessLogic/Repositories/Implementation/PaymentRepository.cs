using Microsoft.EntityFrameworkCore;
using RestaurantApplication.BusinessLogic.Repositories.Interfaces;
using RestaurantApplication.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApplication.BusinessLogic.Repositories.Implementation
{
    public class PaymentRepository : GenericRepository<Payment>//IGenericRepository<Payment>
    {
        //private readonly RestaurantDatabaseContext _context;
        public PaymentRepository(RestaurantDatabaseContext context) : base(context)
        {
           // _context = context;
        }
        /*public bool Add(Payment entity)
        {
            if (entity != null)
            {
                _context.Payments.Add(entity);
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var entity = Get(id);
            if (entity != null)
            {
                _context.Payments.Remove(entity);
                return true;
            }
            return false;
        }

        public Payment Get(int id) => _context.Payments.FirstOrDefault(p => p.PaymentId == id);

        public async Task<List<Payment>> GetAllAsync() => await _context.Payments.ToListAsync();

        public async Task SaveDataAsync() => await _context.SaveChangesAsync();*/
    }
}
