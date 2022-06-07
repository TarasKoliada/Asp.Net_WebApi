using Microsoft.EntityFrameworkCore;
using RestaurantApplication.BusinessLogic.Repositories.Interfaces;
using RestaurantApplication.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApplication.BusinessLogic.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T :  class
    {
        private readonly RestaurantDatabaseContext _context;
        public GenericRepository(RestaurantDatabaseContext context)
        {
            _context = context;
        }
        public bool Add(T entity)
        {
            if (entity != null)
            {
                _context.Set<T>().Add(entity);
                return true;
            }
            return false;
           
        }

        public async Task<bool> Delete(int id)
        {
            var entity = await Get(id);
            if (entity != null)
            {
                _context.Set<T>().Remove(entity);
                return true;
            }
            return false;
        }

        public async Task<T> Get(int id) => await _context.Set<T>().FindAsync(id);

        public async Task<List<T>> GetAllAsync() => await _context.Set<T>().ToListAsync();

        public void Update(T entity) =>  _context.Set<T>().Update(entity);
    }
}
