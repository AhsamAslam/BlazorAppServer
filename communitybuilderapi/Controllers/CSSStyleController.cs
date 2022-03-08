//using MediatR;
//using Microsoft.AspNetCore.Mvc;
//using communitybuilderapi.Commands.CSS.AddCSS;
//using communitybuilderapi.Dtos;
//using communitybuilderapi.Interfaces;
//using communitybuilderapi.Queries.CSS.GetCSS;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace communitybuilderapi.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class CSSStyleController : ApiController
//    {
//        private ICSSRepository _ObjCSSRepository;
//        public CSSStyleController(ICSSRepository ObjCSSRepository)
//        {
//            _ObjCSSRepository = ObjCSSRepository;
//        }
//        // GET: api/CSSStyle
//        [HttpGet]
//        public async Task<List<CustomCssDto>> Get(string SitePage)
//        {
//            return await Mediator.Send(new GetCSSQuery() { SitePage = SitePage});
//        }

//        // GET api/<CSSStyleController>/5
//        [HttpGet("{id}")]
//        public string Get(int id)
//        {
//            return "value";
//        }

//        // POST api/CSSStyle
//        [HttpPost]
//        public async Task<CustomCssDto> Post([FromBody] CustomCssDto CSSDto)
//        {
//            return await Mediator.Send(new AddCSSCommand() { CSSParam = CSSDto });
//        }

//        // PUT api/<CSSStyleController>/5
//        [HttpPut("{id}")]
//        public void Put(int id, [FromBody] string value)
//        {
//        }

//        // DELETE api/<CSSStyleController>/5
//        [HttpDelete("{id}")]
//        public void Delete(int id)
//        {
//        }
//    }
//}
