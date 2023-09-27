﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FootballApp2.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class SofascoreController : ControllerBase
    {
        // GET: api/<SofascoreController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SofascoreController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SofascoreController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SofascoreController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SofascoreController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
