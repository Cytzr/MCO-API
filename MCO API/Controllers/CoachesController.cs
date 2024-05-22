using MCO_API.Data;
using MCO_API.Models.Database;
using MCO_API.Models.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace MCO_API.Controllers
{
    [ApiController]
    public class CoachesController : ControllerBase
    {
        private readonly MCODbContext _context;

        public CoachesController(MCODbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("/coaches/getAllCoaches")]
        public async Task<List<CoachesDatabaseModel>> GetAllCoaches()
        {
            try
            {
                return await (from a in _context.Coaches
                              select a).ToListAsync();
            }
            catch
            {
                throw new Exception();
            }
        }

        [HttpGet]
        [Route("/coaches/getSampleCoaches")]
        public async Task<List<Coaches>> GetSampleCoaches()
        {
            try
            {
                var result = await (from a in _context.Coaches
                                    join b in _context.Games
                                    on a.coachGameID equals b.gameID
                                    select new Coaches
                                    {
                                        coachID = a.coachID,
                                        coachName = a.coachName,
                                        coachDescription = a.coachDescription,
                                        coachPicture = a.coachPicture,
                                        coachPrice = a.coachPrice,
                                        coachRating = a.coachRating,
                                        games = b,
                                    }).ToListAsync();

                List<Coaches> coaches = new List<Coaches>();

                for (int i = 0; i < 8; i++)
                {
                    coaches.Add(result[i]);
                }

                return coaches;
            }
            catch
            {
                throw new Exception();
            }
        }

        [HttpGet]
        [Route("/coaches/getCoachByGame/{gameID:guid}")]
        public async Task<List<Coaches>> GetCoachByGame([FromRoute] Guid gameID)
        {
            try
            {

                var result = await (from a in _context.Coaches
                                    where a.coachGameID == gameID
                                    select new Coaches
                                    {
                                        coachID = a.coachID,
                                        coachName = a.coachName,
                                        coachDescription = a.coachDescription,
                                        coachPicture = a.coachPicture,
                                        coachPrice = a.coachPrice,
                                        coachRating = a.coachRating,
                                        coachGameID = gameID,
                                        games = (from b in _context.Games
                                                 where b.gameID.Equals(gameID)
                                                 select b).FirstOrDefault(),
                                    }).ToListAsync();

                return result;
            }
            catch
            {
                throw new Exception();
            }
        }

        [HttpGet]
        [Route("/coaches/getCoachDetail/{id:guid}")]
        public async Task<IActionResult> GetCoachDetail([FromRoute] Guid id)
        {
            try
            {
                var result = await (from a in _context.Coaches
                                    where a.coachID.Equals(id)
                                    select new Coaches
                                    {
                                        coachID = a.coachID,
                                        coachName = a.coachName,
                                        coachDescription = a.coachDescription,
                                        coachPicture = a.coachPicture,
                                        coachPrice = a.coachPrice,
                                        coachRating = a.coachRating,
                                        coachGameID = a.coachGameID,
                                        games = (from b in _context.Games
                                                 where b.gameID.Equals(a.coachGameID)
                                                 select b).FirstOrDefault(),
                                        comments = (from b in _context.Comments
                                                    where b.commentedUser.Equals(a.coachID)
                                                    select b).ToList(),
                                    }).FirstOrDefaultAsync();
                return Ok(result);
            }
            catch
            {
                throw new Exception();
            }
        }

        [HttpPost]
        [Route("/coaches/coachLogin")]
        public async Task<CoachesDatabaseModel> CoachLogin([FromBody] CoachesDatabaseModel coach)
        {
            try
            {
                var login = await (from a in _context.Coaches
                                   where a.coachPassword.Equals(coach.coachPassword) && a.coachName.Equals(coach.coachName)
                                   select a).FirstOrDefaultAsync();
                return login;
            }
            catch
            {
                throw new Exception();
            }
        }

        [HttpPost]
        [Route("/coaches/insertCoach")]
        public async Task<IActionResult> InsertCoach([FromBody] CoachesDatabaseModel newCoach)
        {
            try
            {
                await _context.Coaches.AddAsync(newCoach);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch
            {
                throw new Exception();
            }
        }

        [HttpPut]
        [Route("/coaches/updateCoach")]
        public async Task<IActionResult> UpdateUser([FromBody] CoachesDatabaseModel updateCoach)
        {
            try
            {
                var result = await _context.Coaches.FindAsync(updateCoach.coachID);
                result = updateCoach;
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch
            {
                throw new Exception();
            }
        }

        [HttpDelete]
        [Route("/coaches/deleteCoach/{id:guid}")]
        public async Task<IActionResult> DeleteUser([FromRoute] Guid id)
        {
            try
            {
                var result = await _context.Coaches.FindAsync(id);
                _context.Coaches.Remove(result);
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
