using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MCO_API.Models.Database
{
    [Table("UserOrders")]
    public class UserOrdersDatabaseModel
    {
        [Key]
        public Guid? orderID { get; set; }
        public Guid? customerID { get; set; }
        public Guid? sellerID { get; set; }
        public String? orderType { get; set; }
        public String? orderStatus { get; set; }
        public int? orderPrice {  get; set; }
    }
}
