using MCO_API.Data;
using MCO_API.Models.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace MCO_API.Repository
{
    public class CommentsRepository
    {
        MCODbContext _context;

        CommentsRepository(MCODbContext context)
        {
            _context = context;
        }

        public async Task<List<CommentsDatabaseModel>> getAllCommentedComments(Guid id)
        {
            try
            {
                var result = await (from a in _context.Comments
                                    where a.commentedUser == id
                                    select a).ToListAsync();

                return result;
            }
            catch
            {
                throw new Exception();
            }
        }

        public async Task insertComment(CommentsDatabaseModel request)
        {
            try
            {
                var result = await _context.Comments.AddAsync(request);
                await _context.SaveChangesAsync();
            }
            catch
            {
                throw new Exception();
            }
        }

        public async Task deleteComment (Guid id)
        {
            try
            {
                var result = await _context.Comments.Where(x => x.commentID == id).FirstOrDefaultAsync();
                _context.Comments.Remove(result);
                await _context.SaveChangesAsync();
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
