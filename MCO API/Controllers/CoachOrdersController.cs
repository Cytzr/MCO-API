using MCO_API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MCO_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoachOrdersController : ControllerBase
    {
        private readonly MCODbContext _context;

        public CoachOrdersController(MCODbContext context)
        {
            _context = context;
        }
    }
}
