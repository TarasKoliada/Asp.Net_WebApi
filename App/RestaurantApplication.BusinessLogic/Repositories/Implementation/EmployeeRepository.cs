using Microsoft.EntityFrameworkCore;
using RestaurantApplication.BusinessLogic.Repositories.Interfaces;
using RestaurantApplication.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApplication.BusinessLogic.Repositories.Implementation
{
    public class EmployeeRepository : GenericRepository<Employee>//IGenericRepository<Employee>
    {

        //private readonly RestaurantDatabaseContext _context;
        public EmployeeRepository(RestaurantDatabaseContext context) : base(context)
        {
            //_context = context;
        }
       /* public bool Add(Employee entity)
        {
            if (entity != null)
            {
                _context.Employees.Add(entity);
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var entity = Get(id);
            if (entity != null)
            {
                _context.Employees.Remove(entity);
                return true;
            }
            return false;
        }

        public Employee Get(int id) => _context.Employees.FirstOrDefault(e => e.EmployeeId == id);

        public async Task<List<Employee>> GetAllAsync() => await _context.Employees.ToListAsync();

        public async Task SaveDataAsync() => await _context.SaveChangesAsync();*/
    }
}
