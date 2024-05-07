using MCO_API.Data;
using MCO_API.Models.Database;
using MCO_API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace MCO_API.Repository
{
    public class UsersRepository
    {
        MCODbContext _context;

        public UsersRepository(MCODbContext _context)
        {
            this._context = _context;
        }

        public async Task<List<Users>> getAllUsersAsync()
        {
            return await (from a in _context.Users
                          join b in _context.Wallets
                          on a.userID equals b.walletUserID
                          join c in _context.Games
                          on a.userGameID equals c.gameID
                          join d in _context.Comments
                          on a.userID equals d.commentedUser
                          join e in _context.UserOrders
                          on a.userID equals e.customerID
                          join f in _context.CoachOrders
                          on a.userID equals f.customerID
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

        public async Task<Users> getUser(Guid id)
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
            return result;
        }

        public async Task<List<Users>> getUserByGame(Guid GameID)
        {
            var result = await (from a in _context.Users
                                where a.userGameID == GameID
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

        public async Task<List<CommentsDatabaseModel>> getUserComments(Guid UserID)
        {
            var result = await (from a in _context.Comments
                                where a.commentedUser == UserID && a.commentType == "User"
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

        public async Task<List<CommentsDatabaseModel>> getCoachComments(Guid UserID)
        {
            var result = await (from a in _context.Comments
                                where a.commentedUser == UserID && a.commentType == "Coach"
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
    }
}
