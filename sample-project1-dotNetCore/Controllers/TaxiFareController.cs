using System;
using System.Collections.Generic;
using System.Linq;
using DatabaseAccessLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace sample_project1_dotNetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxiRideController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<TaxiRideModel> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new TaxiRideModel
            {
                Date = DateTime.Now.AddDays(index),
                Minutes = rng.Next(0, 10),
                Miles = rng.Next(0, 5)

            })
            .ToArray();
        }
    }
}
