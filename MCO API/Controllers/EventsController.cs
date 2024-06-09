using MCO_API.Data;
using MCO_API.Models.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MCO_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly MCODbContext _context;
        public EventsController(MCODbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("/events/getAllEvents")]
        public async Task<List<EventsDatabaseModel>> GetAllEvents()
        {
            try
            {
                var result = await (from a in _context.Events
                                    select a).ToListAsync();
                return result;
            }
            catch
            {
                throw new Exception();
            }
        }

        [HttpGet]
        [Route("/events/getSampleEvents")]
        public async Task<List<EventsDatabaseModel>> GetSampleEvents()
        {
            try
            {
                var result = await (from a in _context.Events
                                    select a).ToListAsync();

                List<EventsDatabaseModel> temp = new List<EventsDatabaseModel>();

                foreach (var e in result)
                {
                    if(temp.Count < 3)
                    {
                        temp.Add(e); 
                    }
                }
                return temp;
            }
            catch
            {
                throw new Exception();
            }
        }

        [HttpGet]
        [Route("/events/getEventByGame/{gameID:guid}")]
        public async Task<List<EventsDatabaseModel>> GetEventByGame([FromRoute] Guid gameID)
        {
            try
            {
                return await (from a in _context.Events
                              where a.eventGameID.Equals(gameID)
                              select a).ToListAsync();
            }
            catch
            {
                throw new Exception();
            }
        }

        [HttpPost]
        [Route("/events/insertEvent")]
        public async Task<IActionResult> InsertEvent([FromBody] EventsDatabaseModel model)
        {
            try
            {
                await _context.Events.AddAsync(model);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch
            {
                throw new Exception();
            }
        }

        [HttpDelete]
        [Route("/events/deleteEvent/{id:guid}")]
        public async Task<IActionResult> DeleteEvent([FromRoute] Guid id)
        {
            try
            {
                var result = await _context.Events.FindAsync(id);  
                _context.Remove(result);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch
            {
                throw new Exception();
            }
        }

    }
}
