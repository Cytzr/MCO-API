using MCO_API.Data;
using MCO_API.Models.Database;
using MCO_API.Models.Domain;
using MCO_API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MCO_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly MCODbContext _context;
        private UserOrdersRepository _userOrdersRepository;

        public UsersController(MCODbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("/GetAllUsers")]
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
        [Route("/GetSampleUsers")]
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
                                        //getgamebyid
                                    }).ToListAsync();

            }
            catch
            {
                throw new Exception();
            }
        }

        [HttpGet]
        [Route("/GetUserByID/{id:guid}")]
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
        [Route("/GetUserByGame/{gameID:guid}")]
        public async Task<List<Users>> GetUserByGame([FromRoute] Guid gameID)
        {
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
                                }).ToListAsync();

            return result;
        }

        [HttpGet]
        [Route("/GetUserComments/{userID:guid}")]
        public async Task<List<CommentsDatabaseModel>> GetUserComments([FromRoute]Guid userID)
        {
            var result = await (from a in _context.Comments
                                where a.commentedUser == userID && a.commentType == "User"
                                select new CommentsDatabaseModel
                                {
                                    commenter = a.commenter,
                                    commentContent = a.commentContent,
                                    commentSender = a.commentSender,
                                    commentRating = a.commentRating,
                                    commentPicture = a.commentPicture,
                                }).ToListAsync();
            return result;
        }

        //[HttpPost]
        //public async Task<IActionResult> AddNewUsers([FromBody] UsersDTO user)
        //{
        //    try
        //    {
        //        Users newUser = new Users()
        //        {
        //            userName = user.userName,
        //            userPassword = user.userPassword,
        //            userDescription = user.userDescription,
        //            userPicture = user.userPicture,
        //            userIsPlayer = user.userIsPlayer,
        //            userPrice = user.userPrice,
        //            userGameID = user.userGameID,
        //        };
        //        await _context.Users.AddAsync(newUser);
        //        await _context.SaveChangesAsync();
        //        return Ok(newUser);
        //    }
        //    catch (Exception ex)
        //    {
        //        return NotFound(ex.Message);
        //    }
        //}

        //[HttpDelete]
        //[Route("{id}")]
        //public async Task<IActionResult> DeleteUser([FromRoute] Guid id)
        //{
        //    try
        //    {
        //        Users user = await _context.Users.FindAsync(id);
        //        _context.Users.Remove(user);
        //        await _context.SaveChangesAsync();
        //        return Ok(user);
        //    }
        //    catch (Exception ex)
        //    {
        //        return NotFound(ex.Message);
        //    }
        //}

        //[HttpPost]
        //public async Task<IActionResult> UpdateUserPrice([FromBody] int price)
        //{
        //    Users existingUser = await _context.Users.FindAsync(update.userID);

        //    if (existingUser == null)
        //    {
        //        return NotFound();
        //    }

        //    existingUser
        //}
    }
}
