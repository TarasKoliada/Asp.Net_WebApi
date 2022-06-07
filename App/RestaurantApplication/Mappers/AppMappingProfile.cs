using AutoMapper;
using RestaurantApplication.Domain.Models;
using RestaurantApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApplication.Mappers
{
    public class AppMappingProfile : Profile
    {
        public AppMappingProfile()
        {
            CreateMap<Customer, CustomerModel>(); 
            CreateMap<CustomerModel, Customer>().ForMember(a => a.CustomerId, opt => opt.Ignore() ); 
        }
    }
}
