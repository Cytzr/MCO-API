﻿using MCO_API.Data;
using MCO_API.Models.Database;
using MCO_API.Models.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MCO_API.Controllers
{
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly MCODbContext _context;

        public UsersController(MCODbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("/users/getAllUsers")]
        public async Task<List<UsersDatabaseModel>> GetAllUsers()
        {
            try 
            {
                return await (from a in _context.Users
                              select a).ToListAsync();
            }
            catch
            {
                throw new Exception();
            }

        }

        [HttpGet]
        [Route("/users/getSampleUsers")]
        public async Task<List<Users>> GetSampleUser()
        {
            try
            {
                var result = await (from a in _context.Users
                                    join b in _context.Games
                                    on a.userGameID equals b.gameID
                                    select new Users
                                    {
                                        userID = a.userID,
                                        userName = a.userName,
                                        userDescription = a.userDescription,
                                        userPicture = a.userPicture,
                                        userPrice = a.userPrice,
                                        userRating = a.userRating,
                                        games = b,
                                    }).ToListAsync();

                List<Users> users = new List<Users>();
                for(int i = 0; i < 8; i++)
                {
                    users.Add(result[i]);
                }

                return users;

            }
            catch
            {
                throw new Exception();
            }
        }

        [HttpGet]
        [Route("/users/getUserByGame/{gameID:guid}")]
        public async Task<List<Users>> GetUserByGame([FromRoute] Guid gameID)
        {
            try
            {
                var game = await (from a in _context.Games
                                  where a.gameID.Equals(gameID)
                                  select a).FirstOrDefaultAsync();

                var result = await (from a in _context.Users
                                    where a.userGameID == gameID
                                    select new Users
                                    {
                                        userID = a.userID,
                                        userName = a.userName,
                                        userDescription = a.userDescription,
                                        userRating = a.userRating,
                                        userPicture = a.userPicture,
                                        userIsPlayer = a.userIsPlayer,
                                        userPrice = a.userPrice,
                                        userGameID = game.gameID,
                                        games = game,
                                    }).ToListAsync();

                return result;
            }
            catch
            {
                throw new Exception();
            }
        }

        [HttpGet]
        [Route("/users/getUserDetail/{id:guid}")]
        public async Task<IActionResult> GetUserDetail([FromRoute] Guid id)
        {
            try
            {

                var result = await (from a in _context.Users
                                    where a.userID.Equals(id)
                                    select new Users
                                    {
                                        userID = a.userID,
                                        userName = a.userName,
                                        userDescription = a.userDescription,
                                        userRating = a.userRating,
                                        userPicture = a.userPicture,
                                        userIsPlayer = a.userIsPlayer,
                                        userPrice = a.userPrice,
                                        userGameID = a.userGameID,
                                        games = (from b in _context.Games
                                                 where b.gameID.Equals(a.userGameID)
                                                 select b).FirstOrDefault(),
                                    }).FirstOrDefaultAsync();
                return Ok(result);
            }
            catch
            {
                throw new Exception();
            }
        }

        [HttpPost]
        [Route("/users/userLogin")]
        public async Task<Users> UserLogin([FromBody] UsersDatabaseModel user)
        {
            try
            {
                Users login = await (from a in _context.Users
                                     where a.userPassword.Equals(user.userPassword) && a.userName.Equals(user.userName)
                                     select new Users()
                                     {
                                         userID = a.userID,
                                         userName = a.userName,
                                         userPassword = a.userPassword,
                                         userDescription = a.userDescription,
                                         userRating = a.userRating,
                                         userPicture = a.userPicture,
                                         userIsPlayer = a.userIsPlayer,
                                         userPrice = a.userPrice,
                                         userGameID = a.userGameID,
                                         wallets = (from b in _context.Wallets
                                                    where b.walletOwnerID == a.userID
                                                    select b).FirstOrDefault(),
                                     }).FirstOrDefaultAsync();

                return login;
            }
            catch
            {
                throw new Exception();
            }
        }

        [HttpPost]
        [Route("/users/insertUser")]
        public async Task<IActionResult> InsertUser([FromBody] UsersDatabaseModel newUser)
        {
            try
            {
                await _context.Users.AddAsync(newUser);
                await _context.SaveChangesAsync();

                UsersDatabaseModel tempUser = (from a in _context.Users
                                           where newUser.userName == a.userName
                                           select a).FirstOrDefault();

                WalletsDatabaseModel tempWallet = new WalletsDatabaseModel();

                tempWallet.walletOwnerID = newUser.userID;
                tempWallet.currencyOwned = 0;

                await _context.Wallets.AddAsync(tempWallet);
                await _context.SaveChangesAsync();

                return Ok();
            }
            catch
            {
                throw new Exception();
            }
        }

        [HttpPost]
        [Route("/users/updateUser")]
        public async Task<IActionResult> UpdateUser([FromBody] UsersDatabaseModel updateUser)
        {
            try
            {
                UsersDatabaseModel result = await (from a in _context.Users
                                    where a.userID == updateUser.userID
                                    select a).FirstOrDefaultAsync();
                result.userName = updateUser.userName;
                result.userPassword = updateUser.userPassword;
                result.userDescription = updateUser.userDescription;
                result.userPicture = updateUser.userPicture;
                result.userIsPlayer = updateUser.userIsPlayer;
                result.userPrice = updateUser.userPrice;
                result.userGameID = updateUser.userGameID;
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch
            {
                throw new Exception();
            }
        }

        [HttpDelete]
        [Route("/users/deleteUser/{id:guid}")]
        public async Task<IActionResult> DeleteUser([FromRoute] Guid id)
        {
            try
            {
                var result = await _context.Users.FindAsync(id);
                _context.Users.Remove(result);
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
