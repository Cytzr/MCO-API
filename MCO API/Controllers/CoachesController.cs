using MCO_API.Data;
using MCO_API.Models.Database;
using MCO_API.Models.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MCO_API.Controllers
{
    [ApiController]
    public class CoachesController : ControllerBase
    {
        private readonly MCODbContext _context;

        public CoachesController(MCODbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("/coaches/getAllCoaches")]
        public async Task<List<CoachesDatabaseModel>> GetAllCoaches()
        {
            return await(from a in _context.Coaches
                         select a).ToListAsync();
        }
    }
}
