﻿using MCO_API.Data;
using MCO_API.Models.Database;
using MCO_API.Models.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MCO_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoachOrdersController : ControllerBase
    {
        private readonly MCODbContext _context;

        public CoachOrdersController(MCODbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("/coachOrders/getOrderByUserID/{id:guid}")]
        public async Task<List<CoachOrders>> GetOrderByUserID([FromRoute] Guid id)
        {
            try
            {
                try
                {
                    List<CoachOrders> list = new List<CoachOrders>();

                    var users = await (from a in _context.CoachOrders
                                       where a.customerID.Equals(id) && a.orderType.Equals("Coaching")
                                       select new CoachOrders
                                       {
                                           orderID = a.orderID,
                                           customerID = a.customerID,
                                           sellerID = a.sellerID,
                                           orderType = a.orderType,
                                           orderStatus = a.orderStatus,
                                           orderPrice = a.orderPrice,
                                           users = (from b in _context.Users
                                                    where b.userID.Equals(a.customerID)
                                                    select new UsersDatabaseModel
                                                    {
                                                        userID = b.userID,
                                                        userName = b.userName,
                                                        userPicture = b.userPicture,
                                                        userPrice = b.userPrice,
                                                    }).FirstOrDefault(),
                                           coaches = (from b in _context.Coaches
                                                      where b.coachID.Equals(a.sellerID)
                                                      select new CoachesDatabaseModel
                                                      {
                                                          coachID = b.coachID,
                                                          coachName = b.coachName,
                                                          coachPicture = b.coachPicture,
                                                          coachPrice = b.coachPrice,
                                                      }).FirstOrDefault(),
                                       }).ToListAsync();

                    list.AddRange(users);
                    return list;
                }
                catch
                {
                    throw new Exception();
                }
            }
            catch
            {
                throw new Exception();
            }
        }

        [HttpGet]
        [Route("/coachOrders/getOrderByCoachID/{id:guid}")]
        public async Task<List<CoachOrders>> GetOrderByCoachID([FromRoute] Guid id)
        {
            try
            {
                List<CoachOrders> list = new List<CoachOrders>();

                var coach = await (from a in _context.CoachOrders
                                   where a.sellerID.Equals(id) && a.orderType.Equals("Coaching")
                                   select new CoachOrders
                                   {
                                       orderID = a.orderID,
                                       customerID = a.customerID,
                                       sellerID = a.sellerID,
                                       orderType = a.orderType,
                                       orderStatus = a.orderStatus,
                                       orderPrice = a.orderPrice,
                                       users = (from b in _context.Users
                                                where b.userID.Equals(a.customerID)
                                                select new UsersDatabaseModel
                                                {
                                                    userID = b.userID,
                                                    userName = b.userName,
                                                    userPicture = b.userPicture,
                                                    userPrice = b.userPrice,
                                                }).FirstOrDefault(),
                                       coaches = (from b in _context.Coaches
                                                  where b.coachID.Equals(a.sellerID)
                                                  select new CoachesDatabaseModel
                                                  {
                                                      coachID = b.coachID,
                                                      coachName = b.coachName,
                                                      coachPicture = b.coachPicture,
                                                      coachPrice = b.coachPrice,
                                                  }).FirstOrDefault(),
                                   }).ToListAsync();

                list.AddRange(coach);
                return list;
            }
            catch
            {
                throw new Exception();
            }
        }

        [HttpPut]
        [Route("/coachOrders/updateStatus/{id:guid}")]
        public async Task<IActionResult> UpdateStatus([FromRoute] Guid id, [FromBody] String status)
        {
            try
            {
                CoachOrdersDatabaseModel result = await _context.CoachOrders.FindAsync(id);
                result.orderStatus = status;
                await _context.SaveChangesAsync();
                return Ok(result);
            }
            catch
            {
                throw new Exception();
            }
        }

        [HttpPost]
        [Route("/coachOrders/insertOrder")]
        public async Task<IActionResult> InsertOrder([FromBody] CoachOrdersDatabaseModel order)
        {
            try
            {
                var result = await _context.CoachOrders.AddAsync(order);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch
            {
                throw new Exception();
            }
        }

        [HttpDelete]
        [Route("/coachOrders/deleteOrder/{id:guid}")]
        public async Task<IActionResult> DeleteOrder([FromRoute] Guid id)
        {
            try
            {
                var delete = await _context.CoachOrders.FindAsync(id);
                var result = _context.CoachOrders.Remove(delete);
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
