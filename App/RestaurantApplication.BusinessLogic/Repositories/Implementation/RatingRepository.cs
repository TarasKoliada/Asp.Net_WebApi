using Microsoft.EntityFrameworkCore;
using RestaurantApplication.BusinessLogic.Repositories.Interfaces;
using RestaurantApplication.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApplication.BusinessLogic.Repositories.Implementation
{
    public class RatingRepository : GenericRepository<Rating>//IGenericRepository<Rating>
    {
        //private readonly RestaurantDatabaseContext _context;
        public RatingRepository(RestaurantDatabaseContext context) : base(context)
        {
            //_context = context;
        }
        /*public bool Add(Rating entity)
        {
            if (entity != null)
            {
                _context.Ratings.Add(entity);
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var entity = Get(id);
            if (entity != null)
            {
                _context.Ratings.Remove(entity);
                return true;
            }
            return false;
        }

        public Rating Get(int id) => _context.Ratings.FirstOrDefault(r => r.RatingId == id);

        public async Task<List<Rating>> GetAllAsync() => await _context.Ratings.ToListAsync();

        public async Task SaveDataAsync() => await _context.SaveChangesAsync();*/
    }
}
