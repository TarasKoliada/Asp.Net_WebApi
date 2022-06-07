using Microsoft.EntityFrameworkCore;
using RestaurantApplication.BusinessLogic.Repositories.Interfaces;
using RestaurantApplication.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApplication.BusinessLogic.Repositories.Implementation
{
    public class CustomerRepository : GenericRepository<Customer>//, IGenericRepository<Customer>
    {
        //private readonly RestaurantDatabaseContext _context;
        public CustomerRepository(RestaurantDatabaseContext context): base(context)//comment base
        {
            //_context = context;
        }
        /*public bool Add(Customer entity)
        {
            if (entity != null)
            {
                _context.Customers.Add(entity);
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var entity = Get(id);
            if (entity != null)
            {
                _context.Customers.Remove(entity);
                return true;
            }
            return false;
        }

        public Customer Get(int id) => _context.Customers.FirstOrDefault(c => c.CustomerId == id);

        public async Task<List<Customer>> GetAllAsync() => await _context.Customers.ToListAsync();

        public async Task SaveDataAsync() => await _context.SaveChangesAsync();*/
    }
}
