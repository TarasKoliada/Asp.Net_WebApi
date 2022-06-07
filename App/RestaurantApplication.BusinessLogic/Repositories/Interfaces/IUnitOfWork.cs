using RestaurantApplication.BusinessLogic.Repositories.Implementation;
using RestaurantApplication.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApplication.BusinessLogic.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        public IGenericRepository<Customer> Customers { get; }
        public OrderRepository Orders { get; }
        public SiteRepository Sites { get; }
        public EmployeeRepository Employees { get; }
        public PaymentRepository Payments { get; }
        public RatingRepository Ratings { get; }
        public AdminRepository Admins { get; }

        public int Complete();
    }
}
