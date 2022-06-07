using Microsoft.Extensions.DependencyInjection;
using RestaurantApplication.BusinessLogic.Repositories.Implementation;
using RestaurantApplication.BusinessLogic.Repositories.Interfaces;
using RestaurantApplication.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApplication.BusinessLogic.Repositories
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IGenericRepository<Customer>, CustomerRepository>();
            services.AddTransient<IUnitOfWork, UoW>();
            return services;
        }
    }
}
