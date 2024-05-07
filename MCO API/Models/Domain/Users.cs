using MCO_API.Models.Database;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCO_API.Models.Domain
{
    public class Users
    {
        public Guid? userID { get; set; }
        public string? userName { get; set; }
        public string? userPassword { get; set; }
        public string? userDescription { get; set; }
        public string? userPicture { get; set; }
        public Boolean? userIsPlayer { get; set; }
        public int? userPrice { get; set; }
        public Guid? userGameID { get; set; }

        //Navigation Properties
        public WalletsDatabaseModel? wallets { get; set; }
        public GamesDatabaseModel? games { get; set; }
        public ICollection<CommentsDatabaseModel>? comments { get; set; }
        public ICollection<UserOrdersDatabaseModel>? userOrders { get; set; }
        public ICollection<CoachOrdersDatabaseModel>? coachOrders { get; set; }
    }
}
