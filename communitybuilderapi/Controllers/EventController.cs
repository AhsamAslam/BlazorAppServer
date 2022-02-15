using Microsoft.AspNetCore.Mvc;
using communitybuilderapi.Commands.Events.AddEvent;
using communitybuilderapi.Dtos;
using communitybuilderapi.Interfaces;
using communitybuilderapi.Queries.Events.GetEvent;
using communitybuilderapi.Queries.Events.GetTopEvent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace communitybuilderapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ApiController
    {
        private IEventRepository _ObjEventRepository;
        public EventController(IEventRepository ObjEventRepository)
        {
            _ObjEventRepository = ObjEventRepository;
        }
        // GET: api/Event/{Id}
        [HttpGet("{id}")]
        public async Task<IEnumerable<EventDto>> Get()
        {
            return await Mediator.Send(new GetEventQuery());
        }

        // GET: api/Event
        [HttpGet]
        public async Task<IEnumerable<EventDto>> GetTopEvent()
        {
            return await Mediator.Send(new GetTopEventQuery());
        }

        // GET api/Event/5
        //[HttpGet("{id}", Name = "Get")]
        //public async Task<Event> Get(int id)
        //{
        //    return _ObjEventRepository.GetEvent(id);
        //}

        // POST api/<EventController>
        [HttpPost]
        public async Task<EventDto> Post([FromBody] EventDto eventDto)
        {
            return await Mediator.Send(new AddEventCommand() { EventParam = eventDto});
        }

        //// PUT api/<EventController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<EventController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
