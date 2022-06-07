using Microsoft.EntityFrameworkCore;
using RestaurantApplication.BusinessLogic.Repositories.Interfaces;
using RestaurantApplication.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApplication.BusinessLogic.Repositories.Implementation
{
    public class AdminRepository : GenericRepository<Administrator>//IGenericRepository<Administrator>
    {
        //private readonly RestaurantDatabaseContext _context;
        public AdminRepository(RestaurantDatabaseContext context) : base(context)
        {
            //_context = context;
        }

        /*public bool Add(Administrator entity)
        {
            if (entity != null)
            {
                _context.Administrators.Add(entity);
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var entity = Get(id);
            if (entity != null)
            {
                _context.Administrators.Remove(entity);
                return true;
            }
            return false;
        }

        public Administrator Get(int id) => _context.Administrators.FirstOrDefault(a => a.AdminId == id);

        public async Task<List<Administrator>> GetAllAsync() => await _context.Administrators.ToListAsync();

        public async Task SaveDataAsync() => await _context.SaveChangesAsync();*/
    }
}
