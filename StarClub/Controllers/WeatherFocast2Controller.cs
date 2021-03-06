﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StarClub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherFocast2Controller : ControllerBase
    {
        // GET: api/WeatherFocast2
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/WeatherFocast2/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/WeatherFocast2
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/WeatherFocast2/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
