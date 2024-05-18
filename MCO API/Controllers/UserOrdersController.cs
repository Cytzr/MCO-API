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
                                       orderID = a.orderID,
                                       customerID = a.customerID,
                                       sellerID = a.sellerID,
                                       orderType = a.orderType,
                                       orderStatus = a.orderStatus,
                                       orderPrice = a.orderPrice,
                                       buyer = (from b in _context.Users
                                                where b.userID.Equals(a.customerID)
                                                select new UsersDatabaseModel
                                                {
                                                    userID = b.userID,
                                                    userName = b.userName,
                                                    userPicture = b.userPicture,
                                                }).FirstOrDefault(),
                                       seller = (from b in _context.Users
                                                 where b.userID.Equals(a.sellerID)
                                                 select new UsersDatabaseModel
                                                 {
                                                     userID=b.userID,
                                                     userName = b.userName,
                                                     userPicture = b.userPicture,
                                                 }).FirstOrDefault(),
                                   }).ToListAsync();
                list.AddRange(buyer);

                var seller = await (from a in _context.UserOrders
                                    where a.sellerID.Equals(id) && a.orderType.Equals("Playing")
                                    select new UserOrders
                                    {
                                        orderID = a.orderID,
                                        customerID = a.customerID,
                                        sellerID = a.sellerID,
                                        orderType = a.orderType,
                                        orderStatus = a.orderStatus,
                                        orderPrice = a.orderPrice,
                                        buyer = (from b in _context.Users
                                                 where b.userID.Equals(a.customerID)
                                                 select new UsersDatabaseModel
                                                 {
                                                     userID = b.userID,
                                                     userName = b.userName,
                                                     userPicture = b.userPicture,
                                                     userPrice = b.userPrice,
                                                 }).FirstOrDefault(),
                                        seller = (from b in _context.Users
                                                  where b.userID.Equals(a.sellerID)
                                                  select new UsersDatabaseModel
                                                  {
                                                      userID = b.userID,
                                                      userName = b.userName,
                                                      userPicture = b.userPicture,
                                                      userPrice = b.userPrice,
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

        [HttpPut]
        [Route("/userOrders/updateStatus/{id:guid}")]
        public async Task<IActionResult> UpdateStatus([FromRoute] Guid id, [FromBody] OrderUpdate update)
        {
            try
            {
                UserOrdersDatabaseModel result = await _context.UserOrders.FindAsync(id);
                result.orderStatus = update.update;
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch
            {
                throw new Exception();
            }
        }

        [HttpPost]
        [Route("/userOrders/insertOrder")]
        public async Task<IActionResult> InsertOrder([FromBody] UserOrdersDatabaseModel order)
        {
            try
            {
                var result = await _context.UserOrders.AddAsync(order);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch
            {
                throw new Exception();
            }
        }

        [HttpDelete]
        [Route("/userOrders/deleteOrder/{id:guid}")]
        public async Task<IActionResult> DeleteOrder([FromRoute] Guid id)
        {
            try
            {
                var delete = await _context.UserOrders.FindAsync(id);
                var result = _context.UserOrders.Remove(delete);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
