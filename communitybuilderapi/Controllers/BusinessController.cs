using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
//using communitybuilderapi.Queries.Businesses.GetBusinessByBusinessID;
//using communitybuilderapi.Queries.Businesses.GetBusinessBySiteID;
//using communitybuilderapi.Queries.Businesses.GetBusinessGrid;
//using communitybuilderapi.Queries.Businesses.GetBusinessName;
//using communitybuilderapi.Queries.Businesses.GetTopBusiness;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using communitybuilderapi.Dtos.BusinessDtos;
using communitybuilderapi.Commands.Business.AddBusiness;
using communitybuilderapi.Queries.Businesses.GetBusinessGrid;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace communitybuilderapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessController : ApiController
    {
        private IWebHostEnvironment _IWebHostEnvironment;
        public BusinessController(IWebHostEnvironment IWebHostEnvironment)
        {
            _IWebHostEnvironment = IWebHostEnvironment;
        }

        //// GET: api/Business
        //[HttpGet]
        //public async Task<IEnumerable<BusinessDto>> GetTopBusiness()
        //{
        //    return await Mediator.Send(new GetTopBusinessQuery());
        //}

        //// GET: api/Business
        //[HttpGet]
        //[Route("BySite")]
        //public async Task<IEnumerable<LocalBusinessCardDto>> GetBusinessBySiteID(int SiteID, string SearchText)
        //{
        //    return await Mediator.Send(new GetBusinessBySiteIDQuery() { SiteID = SiteID, SearchText = SearchText });
        //}
        //[HttpGet]
        //[Route("ByBusinessID")]
        //public async Task<IEnumerable<BusinessDetailDto>> GetBusinessByBusinessID(int BusinessID)
        //{
        //    return await Mediator.Send(new GetBusinessByBusinessIDQuery() { BusinessID = BusinessID });
        //}
        [HttpGet]
        [Route("BusinessGrid")]
        public async Task<IEnumerable<BusinessGridDto>> GetBusinessGrid()
        {
            return await Mediator.Send(new GetBusinessGridQuery());
        }
        //[HttpGet]
        //[Route("BusinessName")]
        //public async Task<IEnumerable<BusinessNameDto>> GetBusinessName()
        //{
        //    return await Mediator.Send(new GetBusinessNameQuery());
        //}

        [HttpPost]
        [Route("AddBusiness")]
        public async Task<AddBusinessDto> AddBusiness(AddBusinessDto Business)
        {
            return await Mediator.Send(new AddBusinessCommand() { BusinessParam = Business });
        }


        [HttpPost]
        [Route("UploadPhoto")]
        public async Task<string> Save(int ID)
        {
            string path = string.Empty;
            if (HttpContext.Request.Form.Files.Any())
            {
                foreach (var file in HttpContext.Request.Form.Files)
                {
                    path = Path.Combine(_IWebHostEnvironment.ContentRootPath, "Upload", file.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
            }
            byte[] ByteArray = System.IO.File.ReadAllBytes(path);

            return Convert.ToBase64String(ByteArray);
        }

        // GET api/<BusinessController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BusinessController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BusinessController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BusinessController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
