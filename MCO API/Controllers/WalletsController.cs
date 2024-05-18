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

        [HttpGet]
        [Route("/wallets/getAllWallets")]
        public async Task<List<WalletsDatabaseModel>> GetAllWallets()
        {
            return await _context.Wallets.ToListAsync();
        }

        [HttpGet]
        [Route("/wallets/getWalletByOwnerID/{id:guid}")]
        public async Task<WalletsDatabaseModel> GetWalletByID([FromRoute] Guid id)
        {
            var result = await (from a in _context.Wallets
                          where a.walletOwnerID.Equals(id)
                          select a).FirstOrDefaultAsync();

            return result;
        }

        [HttpPut]
        [Route("/wallets/purchaseService/{id:guid}")]
        public async Task<IActionResult> PurchaseService([FromRoute] Guid id, [FromBody] WalletUpdate update)
        {
            try
            {
                var result = await (from a in _context.Wallets
                                    where a.walletOwnerID.Equals(id)
                                    select a).FirstOrDefaultAsync();
                result.currencyOwned += update.value;
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
        public async Task<IActionResult> InsertWallet([FromBody] WalletsDatabaseModel wallet)
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

        [HttpDelete]
        [Route("/wallets/deleteWallet/{id:guid}")]
        public async Task<IActionResult> DeleteWallet([FromRoute] Guid id)
        {
            try
            {
                var delete = await (from a in _context.Wallets
                                    where a.walletOwnerID.Equals(id)
                                    select a).FirstOrDefaultAsync();
                _context.Remove(delete);
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
