using MCO_API.Data;
using MCO_API.Models.Database;
using MCO_API.Models.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MCO_API.Controllers
{
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly MCODbContext _context;

        public GamesController(MCODbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("/games/getAllGames")]
        public async Task<List<GamesDatabaseModel>> GetAllGames()
        {
            try
            {
                var result = await (from a in _context.Games
                                    select a).ToListAsync();

                return result;
            }
            catch
            {
                throw new Exception();
            }
        }

        [HttpGet]
        [Route("/games/getGameByID/{id:guid}")]
        public async Task<GamesDatabaseModel> GetGameByID([FromRoute] Guid id)
        {
            try
            {
                var result = await (from a in _context.Games
                                    where a.gameID.Equals(id)
                                    select a).FirstOrDefaultAsync();

                return result;
            }
            catch
            {
                throw new Exception();
            }
        }

        [HttpPost]
        [Route("/games/insertGame")]
        public async Task<IActionResult> InsertGame([FromBody] GamesDatabaseModel game)
        {
            try
            {
                var result = await _context.Games.AddAsync(game);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch
            {
                throw new Exception();
            }
        }

        [HttpDelete]
        [Route("/games/deleteGame/{id:guid}")]
        public async Task<IActionResult> DeleteGame([FromRoute] Guid id)
        {
            try
            {
                var delete = await _context.Games.FindAsync(id);
                _context.Games.Remove(delete);
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
