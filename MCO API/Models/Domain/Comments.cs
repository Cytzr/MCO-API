using MCO_API.Models.Database;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCO_API.Models.Domain
{
    public class Comments
    {
        public Guid? commentID { get; set; }
        public Guid? commentedUser {  get; set; }
        public string? commenter { get; set; }
        public string? commentContent { get; set; }
        public string? commentSender { get; set; }
        public int? commentRating { get; set; }
        public string? commentPicture { get; set; }
        public string? commentType { get; set; }

        //Navigation Properties
        public UsersDatabaseModel? users { get; set; }
        public CoachesDatabaseModel? coaches { get; set; }

    }
}
