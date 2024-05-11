using MCO_API.Data;
using MCO_API.Models.Database;
using MCO_API.Models.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MCO_API.Controllers
{
    [ApiController]
    public class UserOrdersController : ControllerBase
    {
        private readonly MCODbContext _context;

        public UserOrdersController(MCODbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("/userOrders/getOrderByUserID/{id:guid}")]
        public async Task<List<UserOrders>> GetOrderByUserID([FromRoute] Guid id)
        {
            try
            {
                List<UserOrders> list = new List<UserOrders>();
                var buyer = await (from a in _context.UserOrders
                                   where a.customerID.Equals(id) && a.orderType.Equals("Playing")
                                   select new UserOrders
                                   {
                                       customerID = a.customerID,
                                       sellerID = a.sellerID,
                                       orderType = a.orderType,
                                       orderStatus = a.orderStatus,
                                       orderPrice = a.orderPrice,
                                       buyer = (from b in _context.Users
                                                where b.userID.Equals(a.customerID)
                                                select new UsersDatabaseModel
                                                {
                                                    userName = b.userName,
                                                    userPicture = b.userPicture,
                                                }).FirstOrDefault(),
                                       seller = (from b in _context.Users
                                                 where b.userID.Equals(a.sellerID)
                                                 select new UsersDatabaseModel
                                                 {
                                                     userName = b.userName,
                                                     userPicture = b.userPicture,
                                                 }).FirstOrDefault(),
                                   }).ToListAsync();
                list.AddRange(buyer);

                var seller = await (from a in _context.UserOrders
                                    where a.sellerID.Equals(id) && a.orderType.Equals("Coaching")
                                    select new UserOrders
                                    {
                                        customerID = a.customerID,
                                        sellerID = a.sellerID,
                                        orderType = a.orderType,
                                        orderStatus = a.orderStatus,
                                        orderPrice = a.orderPrice,
                                        buyer = (from b in _context.Users
                                                 where b.userID.Equals(a.customerID)
                                                 select new UsersDatabaseModel
                                                 {
                                                     userName = b.userName,
                                                     userPicture = b.userPicture,
                                                 }).FirstOrDefault(),
                                        seller = (from b in _context.Users
                                                  where b.userID.Equals(a.sellerID)
                                                  select new UsersDatabaseModel
                                                  {
                                                      userName = b.userName,
                                                      userPicture = b.userPicture,
                                                  }).FirstOrDefault(),
                                    }).ToListAsync();
                list.AddRange(seller);

                return list;
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
