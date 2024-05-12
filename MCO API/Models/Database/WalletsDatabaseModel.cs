using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCO_API.Models.Database
{
    [Table("Wallets")]
    public class WalletsDatabaseModel
    {
        [Key]
        public Guid walletID { get; set; }
        public Guid? walletOwnerID { get; set; }
        public int currencyOwned { get; set; }
    }
}
