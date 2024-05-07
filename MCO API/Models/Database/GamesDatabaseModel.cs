using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCO_API.Models.Database
{
    [Table("Games")]
    public class GamesDatabaseModel
    {
        [Key]
        public Guid? gameID { get; set; }
        public string? gameName { get; set;}
        public string? gamePicture { get; set;}
    }
}
