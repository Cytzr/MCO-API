using MCO_API.Models.Database;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace MCO_API.Models.Domain
{
    public class Coaches
    {
        public Guid? coachID;
        public string? coachName { get; set; }
        public string? coachPassword { get; set; }
        public string? coachDescription { get; set; }
        public string? coachPicture { get; set; }
        public int? coachPrice { get; set; }
        public Guid? coachGameID { get; set; } 

        //Navigation properties
        public WalletsDatabaseModel? wallets { get; set; }
        public GamesDatabaseModel? games { get; set; }
        public ICollection<CommentsDatabaseModel>? comments { get; set; }
        public ICollection<CoachOrdersDatabaseModel>? coachOrders { get; set; }
    }
}
