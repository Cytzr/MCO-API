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
        public async Task<List<UsersDatabaseModel>> GetAllUsers()
        {
            try 
            {
                return await (from a in _context.Users
                              select a).ToListAsync();
            }
            catch
            {
                throw new Exception();
            }

        }

        [HttpGet]
        [Route("/users/getSampleUsers")]
        public async Task<List<Users>> GetSampleUser()
        {
            try
            {
                var result = await (from a in _context.Users
                                    join b in _context.Games
                                    on a.userGameID equals b.gameID
                                    select new Users
                                    {
                                        userID = a.userID,
                                        userName = a.userName,
                                        userDescription = a.userDescription,
                                        userPicture = a.userPicture,
                                        userPrice = a.userPrice,
                                        games = b,
                                    }).ToListAsync();

                List<Users> users = new List<Users>();
                for(int i = 0; i < 8; i++)
                {
                    users.Add(result[i]);
                }

                return users;

            }
            catch
            {
                throw new Exception();
            }
        }

        [HttpGet]
        [Route("/users/getUserByGame/{gameID:guid}")]
        public async Task<List<Users>> GetUserByGame([FromRoute] Guid gameID)
        {
            try
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
            catch
            {
                throw new Exception();
            }
        }

        [HttpGet]
        [Route("/users/getUserDetail/{id:guid}")]
        public async Task<IActionResult> GetUserDetail([FromRoute] Guid id)
        {
            try
            {

                var result = await (from a in _context.Users
                                    select new Users
                                    {
                                        userID = a.userID,
                                        userName = a.userName,
                                        userDescription = a.userDescription,
                                        userPicture = a.userPicture,
                                        userIsPlayer = a.userIsPlayer,
                                        userPrice = a.userPrice,
                                        userGameID = a.userGameID,
                                        games = (from b in _context.Games
                                                 where b.gameID.Equals(a.userGameID)
                                                 select b).FirstOrDefault(),
                                    }).FirstOrDefaultAsync();
                return Ok(result);
            }
            catch
            {
                throw new Exception();
            }
        }

        [HttpPost]
        [Route("/users/userLogin")]
        public async Task<UsersDatabaseModel> UserLogin([FromBody] UsersDatabaseModel user)
        {
            try
            {
                var login = await (from a in _context.Users
                                   where a.userPassword.Equals(user.userPassword) && a.userName.Equals(user.userName)
                                   select a).FirstOrDefaultAsync();
                return login;
            }
            catch
            {
                throw new Exception();
            }
        }

        [HttpPost]
        [Route("/users/insertUser")]
        public async Task<IActionResult> InsertUser([FromBody] UsersDatabaseModel newUser)
        {
            try
            {
                await _context.Users.AddAsync(newUser);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch
            {
                throw new Exception();
            }
        }

        [HttpPut]
        [Route("/users/updateUser")]
        public async Task<IActionResult> UpdateUser([FromBody] UsersDatabaseModel updateUser)
        {
            try
            {
                var result = await _context.Users.FindAsync(updateUser.userID);
                result = updateUser;
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch
            {
                throw new Exception();
            }
        }

        [HttpDelete]
        [Route("/users/deleteUser/{id:guid}")]
        public async Task<IActionResult> DeleteUser([FromRoute] Guid id)
        {
            try
            {
                var result = await _context.Users.FindAsync(id);
                _context.Users.Remove(result);
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
