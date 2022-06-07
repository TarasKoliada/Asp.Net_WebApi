using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using RestaurantApplication.BusinessLogic.Repositories;
using System.Linq;
using System.Threading.Tasks;
using RestaurantApplication.Domain.Models;
using AutoMapper;
using RestaurantApplication.ViewModels;
using RestaurantApplication.BusinessLogic.Repositories.Interfaces;

namespace RestaurantApplication.Controllers
{
    [Route("Customer/{action}")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly IUnitOfWork _unit;
        private readonly IMapper _mapper;
        public CustomerController(IMapper mapper, IUnitOfWork unit)
        {
            _unit = unit;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var customers = await _unit.Customers.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<CustomerModel>>(customers));
        }

        [HttpGet("{id}", Name = "CustomerGet")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var customer = await _unit.Customers.Get(id);
                if (customer == null) return NotFound($"The customer with id {id} was not found");

                return Ok(customer);
            }
            catch (Exception) { }
            return BadRequest("Could not found Customer");
        }

        [HttpPost]
        public IActionResult Post([FromBody] Customer customer)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest(ModelState);

                if (_unit.Customers.Add(customer))
                {
                    _unit.Complete();
                    //await unit.Customers.SaveDataAsync();
                    var url = Url.Link("CustomerGet", new { id = customer.CustomerId });
                    return Created(url, customer);
                }
            }
            catch (Exception)
            { }
            return BadRequest("Could not Post Customer");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] CustomerModel customer)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest(ModelState);

                var customerToChange = _unit.Customers.Get(id).Result;

                if (customerToChange == null) return NotFound($"Couldn`t find the customer with id {id}");

                _mapper.Map(customer, customerToChange);
                //await unit.Customers.SaveDataAsync();
                _unit.Complete();

                return Ok(_mapper.Map<CustomerModel>(customerToChange));
            }
            catch (Exception) {}
            return BadRequest("Could not update Customer");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                if (!await _unit.Customers.Delete(id)/*!unit.Customers.Delete(id)*/) return NotFound($"Couldn`t find the customer with id {id}");

                _unit.Complete();
                //await unit.Customers.SaveDataAsync();
                return Ok();
            }
            catch (Exception) { }
            return BadRequest("Couldn`t Delete Customer");
        }

    }
}
