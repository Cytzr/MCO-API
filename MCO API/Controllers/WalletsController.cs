using MCO_API.Data;
using MCO_API.Models.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MCO_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalletsController : ControllerBase
    {
        private readonly MCODbContext _context;

        public WalletsController(MCODbContext context)
        {
            _context = context;
        }
    }
}
