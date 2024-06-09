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
        [Route("/comments/getComments/{userID:guid}")]
        public async Task<List<CommentsDatabaseModel>> GetUserComments([FromRoute] Guid userID)
        {
            try
            {
                var result = await (from a in _context.Comments
                                    where a.commentedUser == userID
                                    select new CommentsDatabaseModel
                                    {
                                        commentID = a.commentID,
                                        commentedUser = a.commentedUser,
                                        commentContent = a.commentContent,
                                        commentSender = a.commentSender,
                                        commentRating = a.commentRating,
                                        commentPicture = a.commentPicture,
                                        commentTime = a.commentTime,
                                        commentType = a.commentType,
                                    }).ToListAsync();
                return result;
            }
            catch
            {
                throw new Exception();
            }
        }

        [HttpGet]
        [Route("/comments/getSampleComments")]
        public async Task<List<CommentsDatabaseModel>> GetSampleComments()
        {
            try
            {
                var result = await (from a in _context.Comments
                                    select new CommentsDatabaseModel
                                    {
                                        commentID = a.commentID,
                                        commentedUser = a.commentedUser,
                                        commentContent = a.commentContent,
                                        commentSender = a.commentSender,
                                        commentRating = a.commentRating,
                                        commentPicture = a.commentPicture,
                                        commentTime = a.commentTime,
                                        commentType = a.commentType,
                                    }).ToListAsync();

                List<CommentsDatabaseModel> temp = new List<CommentsDatabaseModel>();

                foreach (var comment in result)
                {
                    if(temp.Count >= 6)
                    {
                        break;
                    }
                    temp.Add(comment);
                }

                return temp;
            }
            catch
            {
                throw new Exception();
            }
        }

        [HttpPost]
        [Route("/comments/insertComment")]
        public async Task<IActionResult> InsertComment([FromBody] CommentsDatabaseModel comment)
        {
            try
            {
                comment.commentTime = DateTime.Now.ToString("MM-dd-yyyy");
                var result = await _context.Comments.AddAsync(comment);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch
            {
                throw new Exception();
            }
        }

        [HttpDelete]
        [Route("/comments/deleteComment/{id:guid}")]
        public async Task<IActionResult> DeleteComment([FromRoute] Guid id)
        {
            try
            {
                var delete = await _context.Comments.FindAsync(id);
                _context.Comments.Remove(delete);
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
