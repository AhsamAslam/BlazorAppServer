//using Microsoft.AspNetCore.Mvc;
//using communitybuilderapi.Models;
//using communitybuilderapi.Interfaces;
//using communitybuilderapi.Queries.Sites.GetAllSites;
//using communitybuilderapi.Queries.Sites.GetSiteIDByURL;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using communitybuilderapi.Queries.Sites.GetSiteBySiteURL;
//using communitybuilderapi.Dtos;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace communitybuilderapi.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class SiteController : ApiController
//    {
//        private ISiteRepository _ObjSiteRepository;
//        public SiteController(ISiteRepository ObjSiteRepository)
//        {
//            _ObjSiteRepository = ObjSiteRepository;
//        }
//        // GET: api/<SiteController>
//        [HttpGet]
//        public async Task<IEnumerable<SiteDto>> GetAllSites()
//        {
//            return await Mediator.Send(new GetAllSitesQuery());
//        }

//        // GET: api/Site
//        [Route("GetSiteID")]
//        [HttpGet]
//        public async Task<int> GetSiteIDByURL(string SiteURL)
//        {
//            return await Mediator.Send(new GetSiteIDByURLQuery() { SiteURL = SiteURL});
            
//        }
//        [Route("GetSiteByURL")]
//        [HttpGet]
//        public async Task<SiteDto> GetSiteBySiteURL(string SiteURL)
//        {
//            return await Mediator.Send(new GetSiteBySiteURLQuery() { SiteURL = SiteURL });

//        }
//        // GET api/<SiteController>/5
//        [HttpGet("{id}")]
//        public string Get(int id)
//        {
//            return "value";
//        }

//        // POST api/<SiteController>
//        [HttpPost]
//        public void Post([FromBody] string value)
//        {
//        }

//        // PUT api/<SiteController>/5
//        [HttpPut("{id}")]
//        public void Put(int id, [FromBody] string value)
//        {
//        }

//        // DELETE api/<SiteController>/5
//        [HttpDelete("{id}")]
//        public void Delete(int id)
//        {
//        }
//    }
//}
