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
            var result = await(from a in _context.Games
                               select a).ToListAsync();

            return result;
        }

        [HttpGet]
        [Route("/games/getGameByID/{id:guid}")]
        public async Task<GamesDatabaseModel> GetGameByID([FromRoute] Guid id)
        {
            var result = await (from a in _context.Games
                                where a.gameID.Equals(id)
                                select a).FirstOrDefaultAsync();

            return result;
        }
    }
}
