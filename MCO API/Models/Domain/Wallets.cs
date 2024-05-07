using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCO_API.Models.Domain
{
    public class Wallets
    {
        public Guid walletID { get; set; }
        public Guid? walletUserID { get; set; }
        public Guid? walletCoachID { get; set; }
        public int currencyOwned { get; set; }

        //Navigation Properties
        public Users? users { get; set; }
        public Coaches? coaches { get; set; }
    }
}
