using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestaurantApplication.BusinessLogic.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Get(int id);
        Task<List<T>> GetAllAsync();
        bool Add(T entity);
        Task<bool> Delete(int id);
        void Update(T entity);
    }
}
