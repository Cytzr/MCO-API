using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MCO_API.Models.Database;

namespace MCO_API.Models.Domain
{
    public class UserOrders
    {
        public Guid? orderID { get; set; }
        public Guid? customerID { get; set; }
        public Guid? sellerID { get; set; }
        public String? orderType { get; set; }
        public String? orderStatus { get; set; }
        public int? orderPrice {  get; set; }
        public int? orderRating { get; set; }
        //Navigation Properties
        public UsersDatabaseModel? buyer { get; set; }
        public UsersDatabaseModel? seller { get; set; }
    }
}
