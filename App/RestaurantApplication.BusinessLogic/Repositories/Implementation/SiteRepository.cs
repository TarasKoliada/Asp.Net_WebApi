using Microsoft.EntityFrameworkCore;
using RestaurantApplication.BusinessLogic.Repositories.Interfaces;
using RestaurantApplication.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApplication.BusinessLogic.Repositories.Implementation
{
    public class SiteRepository : GenericRepository<SiteInfo>//IGenericRepository<SiteInfo>
    {
        //private readonly RestaurantDatabaseContext _context;
        public SiteRepository(RestaurantDatabaseContext context) : base(context)
        {
           // _context = context;
        }
       /* public bool Add(SiteInfo entity)
        {
            if (entity != null)
            {
                _context.SiteInfos.Add(entity);
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var entity = Get(id);
            if (entity != null)
            {
                _context.SiteInfos.Remove(entity);
                return true;
            }
            return false;
        }

        public SiteInfo Get(int id) => _context.SiteInfos.FirstOrDefault(s => s.SiteId == id);


        public async Task<List<SiteInfo>> GetAllAsync() => await _context.SiteInfos.ToListAsync();

        public async Task SaveDataAsync() => await _context.SaveChangesAsync();*/
    }
}
