using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCO_API.Models.Domain
{
    public class Games
    {
        public Guid? gameID { get; set; }
        public string? gameName { get; set;}
        public string? gamePicture { get; set;}

        //Navigation Properties
        public ICollection<Users>? users { get; set; }
        public ICollection<Coaches>? coaches { get; set; }
        public ICollection<Events>? events { get; set; }
    }
}
