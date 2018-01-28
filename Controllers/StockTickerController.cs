using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using angular_training_samples_backend.Models;

namespace angular_training_samples_backend.Controllers
{
    [Route("api/[controller]")]
    public class StockTickerController : Controller
    {

        // GET api/order/5
        [HttpGet("{id}")]
        public Stock Get(string id)
        {
            var rnd = new Random((int)DateTime.UtcNow.Ticks);
            return new Stock() { Symbol = id, Value = (rnd.Next() % 1000) * 1.23m};
        }
    }
}
