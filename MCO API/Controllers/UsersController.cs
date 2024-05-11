using MCO_API.Data;
using MCO_API.Models.Database;
using MCO_API.Models.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MCO_API.Controllers
{
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly MCODbContext _context;

        public UsersController(MCODbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("/users/getAllUsers")]
        public async Task<List<Users>> GetAllUsers()
        {
            try 
            {
                return await (from a in _context.Users
                              join b in _context.Wallets
                              on a.userID equals b.walletUserID
                              join c in _context.Games
                              on a.userGameID equals c.gameID
                              join d in _context.Comments
                              on a.userID equals d.commentedUser
                              join e in _context.UserOrders
                              on a.userID equals e.sellerID
                              select new Users
                              {
                                  userID = a.userID,
                                  userName = a.userName,
                                  userDescription = a.userDescription,
                                  userPicture = a.userPicture,
                                  userIsPlayer = a.userIsPlayer,
                                  userPrice = a.userPrice,
                                  userGameID = a.userGameID,
                                  wallets = b,
                                  games = c,
                              }).ToListAsync();
            }
            catch
            {
                return new List<Users>();
            }

        }

        [HttpGet]
        [Route("/users/getSampleUsers")]
        public async Task<List<Users>> GetSampleUser()
        {
            try
            {
                var result = await (from a in _context.Users
                                    select new Users
                                    {
                                        userName = a.userName,
                                        userDescription = a.userDescription,
                                        userPicture = a.userPicture,
                                        userPrice = a.userPrice,
                                    }).ToListAsync();
                return result;

            }
            catch
            {
                throw new Exception();
            }
        }

        [HttpGet]
        [Route("/users/getUserByID/{id:guid}")]
        public async Task<IActionResult> GetUserById([FromRoute] Guid id)
        {
            try
            {
                var result = await (from a in _context.Users
                                    where a.userID == id
                                    select new Users
                                    {
                                        userID = a.userID,
                                        userName = a.userName,
                                        userDescription = a.userDescription,
                                        userPicture = a.userPicture,
                                        userIsPlayer = a.userIsPlayer,
                                        userPrice = a.userPrice,
                                    }).FirstOrDefaultAsync();
                return Ok(result);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpGet]
        [Route("/users/getUserByGame/{gameID:guid}")]
        public async Task<List<Users>> GetUserByGame([FromRoute] Guid gameID)
        {
            var game = await (from a in _context.Games
                              where a.gameID.Equals(gameID)
                              select a).FirstOrDefaultAsync();

            var result = await (from a in _context.Users
                                where a.userGameID == gameID
                                select new Users
                                {
                                    userID = a.userID,
                                    userName = a.userName,
                                    userDescription = a.userDescription,
                                    userPicture = a.userPicture,
                                    userIsPlayer = a.userIsPlayer,
                                    userPrice = a.userPrice,
                                    userGameID = game.gameID,
                                    games = game,
                                }).ToListAsync();

            return result;
        }
    }
}
