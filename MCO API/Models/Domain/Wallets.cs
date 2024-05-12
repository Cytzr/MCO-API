using MCO_API.Models.Database;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCO_API.Models.Domain
{
    public class Wallets
    {
        public Guid walletID { get; set; }
        public Guid? walletOwnerID { get; set; }
        public int currencyOwned { get; set; }

        //Navigation Properties
        public UsersDatabaseModel? users { get; set; }
        public CoachesDatabaseModel? coaches { get; set; }
    }
}
