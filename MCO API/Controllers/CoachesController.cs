using MCO_API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MCO_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoachesController : ControllerBase
    {
        private readonly MCODbContext _context;

        public CoachesController(MCODbContext context)
        {
            _context = context;
        }
    }
}
