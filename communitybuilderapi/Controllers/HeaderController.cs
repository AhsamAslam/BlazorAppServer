//using Microsoft.AspNetCore.Mvc;
//using communitybuilderapi.Dtos;
//using communitybuilderapi.Queries.Header.GetHeaderBySiteID;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace communitybuilderapi.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class HeaderController : ApiController
//    {
//        // GET: api/<HeaderController>
//        [HttpGet]
//        [Route("BySiteID")]
//        public async Task<SiteHeaders> GetHeaderBySiteIDAndSitePage(int SiteID, string SitePage)
//        {
//            return await Mediator.Send(new GetHeaderBySiteIDQuery() { SiteID = SiteID, SitePage = SitePage });
//        }

//        // GET api/<HeaderController>/5
//        [HttpGet("{id}")]
//        public string Get(int id)
//        {
//            return "value";
//        }

//        // POST api/<HeaderController>
//        [HttpPost]
//        public void Post([FromBody] string value)
//        {
//        }

//        // PUT api/<HeaderController>/5
//        [HttpPut("{id}")]
//        public void Put(int id, [FromBody] string value)
//        {
//        }

//        // DELETE api/<HeaderController>/5
//        [HttpDelete("{id}")]
//        public void Delete(int id)
//        {
//        }
//    }
//}
