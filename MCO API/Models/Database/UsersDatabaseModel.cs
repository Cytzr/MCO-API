using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCO_API.Models.Database
{
    [Table("Users")]
    public class UsersDatabaseModel
    {
        [Key]
        public Guid? userID { get; set; }
        public string? userName { get; set; }
        public string? userPassword { get; set; }
        public string? userDescription { get; set; }
        public double? userRating { get; set; }
        public string? userPicture { get; set; }
        public Boolean? userIsPlayer { get; set; }
        public int? userPrice { get; set; }
        public Guid? userGameID { get; set; }
    }
}
