using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using angular_training_samples_backend.Models;

namespace angular_training_samples_backend.Controllers
{
    [Route("api/[controller]")]
    public class CustomersController : Controller
    {
        private static Customer[] Customers = new Customer[] { 
                new Customer() { Id = 1, Name = "Voest Alpine GmbH" },
                new Customer() { Id = 2, Name = "Greiner Packaging GmbH" },
                new Customer() { Id = 3, Name = "TGW Logistics Group GmbH" }
             };

        // GET api/customers
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return Customers;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return Customers.SingleOrDefault(c => c.Id == id);
        }
    }
}
