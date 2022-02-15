using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using communitybuilderapi.Queries.Localization.GetLanguagesBySiteID;
using communitybuilderapi.Interfaces;
using communitybuilderapi.Queries.Localization.GetLocalizationBySiteURL;
using communitybuilderapi.Queries.Localization.GetGenericLocalization;
using communitybuilderapi.Dtos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace communitybuilderapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocalizationController : ApiController
    {
        private ILocalizationRepository _localizationRepository;
        public LocalizationController(ILocalizationRepository localizationRepository)
        {
            _localizationRepository = localizationRepository;
        }
        // GET: api/Localization
        [Route("Language")]
        [HttpGet]
        public async Task<IEnumerable<LanguageDto>> GetLanguages(int SiteID)
        {
            //var location = new Uri($"{Request.Scheme}://{Request.Host}{Request.Path}{Request.QueryString}");
            //var url = location.AbsoluteUri;

            return await Mediator.Send(new GetLanguagesBySiteIDQuery() { SiteID = SiteID });
        }
        // GET: api/Localization
        [Route("Generic")]
        [HttpGet]
        public async Task<IEnumerable<GenericLocalizationKeyValuesDto>> GetGenericLocalization(int LanguageId)
        {
            return await Mediator.Send(new GetGenericLocalizationQuery() { LanguageId = LanguageId});
        }

        // GET: api/Localization
        [HttpGet]
        public async Task<IEnumerable<LanguageLocalizationDto>> GetLocalization(int SiteID)
        {
            return await Mediator.Send(new GetLocalizationBySiteURLQuery() { SiteID = SiteID });
        }

        // GET api/<LocalizationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LocalizationController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LocalizationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LocalizationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
