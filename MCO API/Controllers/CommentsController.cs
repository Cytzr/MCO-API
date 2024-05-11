using MCO_API.Data;
using MCO_API.Models.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MCO_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly MCODbContext _context;

        public CommentsController(MCODbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("/comments/getUserComments/{userID:guid}")]
        public async Task<List<CommentsDatabaseModel>> GetUserComments([FromRoute] Guid userID)
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
    }
}
