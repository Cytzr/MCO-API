using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCO_API.Models.Database
{
    [Table("Comments")]
    public class CommentsDatabaseModel
    {
        [Key]
        public Guid? commentID { get; set; }
        public Guid? commentedUser {  get; set; }
        public string? commentContent { get; set; }
        public string? commentSender { get; set; }
        public int? commentRating { get; set; }
        public string? commentPicture { get; set; }
        public string? commentType { get; set; }
        public string? commentTime { get; set; }
    }
}
