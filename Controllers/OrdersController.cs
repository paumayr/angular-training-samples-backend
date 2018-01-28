using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using angular_training_samples_backend.Models;

namespace angular_training_samples_backend.Controllers
{
    [Route("api/[controller]")]
    public class OrdersController : Controller
    {
        private static Order[] Orders = new Order[] { 
                new Order() 
                { 
                    Id = 1, 
                    CustomerId = 1, 
                    Amount = 134.00m,
                    Items = new string[] {
                        "Angular Training",
                        "C++ Performance Tuning",
                        "ScrumBan Crash-Kurs"
                    } 
                },
                new Order() 
                { 
                    Id = 2, 
                    CustomerId = 1, 
                    Amount = 414.00m,
                    Items = new string[] {
                        "Kaugummi",
                        "Kaiser-Semmerl",
                        "Stahlwerk"
                    } 
                },
                new Order() { 
                    Id = 3,
                    CustomerId = 2,
                    Amount = 43.00m,
                    Items = new string[]{
                        "Fahrradhelm",
                        "Autoreifen",
                        "Dampfgarer"
                    } 
                },
                new Order() { 
                    Id = 4,
                    CustomerId = 3,
                    Amount = 430.00m,
                    Items = new string[]{
                        "Aluminium Profile",
                        "Stahlgerüst",
                        "Elektromotoren"
                    } 
                }
             };

        // GET api/orders
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return Orders;
        }

        // GET api/order/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return Orders.SingleOrDefault(c => c.Id == id);
        }
    }
}
