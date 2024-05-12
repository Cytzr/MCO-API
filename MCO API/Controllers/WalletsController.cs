using MCO_API.Data;
using MCO_API.Models.Database;
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

        [HttpPut]
        [Route("/wallets/purchaseService/{id:guid}")]
        public async Task<IActionResult> purchaseService([FromRoute] Guid id, [FromBody] int price)
        {
            try
            {
                var result = await _context.Wallets.FindAsync(id);
                _context.Wallets.Remove(result);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch
            {
                throw new Exception();
            }
        }

        [HttpPost]
        [Route("/wallets/insertWallet")]
        public async Task<IActionResult> insertWallet([FromBody] WalletsDatabaseModel wallet)
        {
            try
            {
                await _context.AddAsync(wallet);
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
