using Microsoft.AspNetCore.Mvc;
using communitybuilderapi.Dtos;
using communitybuilderapi.Queries.Fans.GetTopFan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace communitybuilderapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FanController : ApiController
    {

        // GET: api/Fan
        [HttpGet]
        public async Task<IEnumerable<BusinessFans>> GetBusinessFan()
        {
            return await Mediator.Send(new GetTopFanQuery());
        }

        // GET api/<FanController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FanController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FanController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FanController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
