using MCO_API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MCO_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly MCODbContext _context;

        public GamesController(MCODbContext context)
        {
            _context = context;
        }
    }
}
