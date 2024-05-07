using MCO_API.Data;
using MCO_API.Models.Database;
using MCO_API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace MCO_API.Repository
{
    public class UserOrdersRepository
    {
        MCODbContext _context;

        UserOrdersRepository(MCODbContext context)
        {
            _context = context;
        }

        public async Task addOrder(UserOrdersDatabaseModel request)
        {
            await _context.UserOrders.AddAsync(request);
            await _context.SaveChangesAsync();
        }

    }
}
