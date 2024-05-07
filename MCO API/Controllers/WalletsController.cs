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

        //[HttpGet]
        //public async Task<List<Wallets>> GetAllWallets()
        //{
        //    return await _context.Wallets.ToListAsync();
        //}
    }
}
