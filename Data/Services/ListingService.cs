using Auction_ASP_Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Auction_ASP_Core.Data.Services
{
    public class ListingService : IListingService
    {
        readonly ApplicationDbContext _context;

        public ListingService(ApplicationDbContext context)
        {
            _context = context;
        }

        IQueryable<Listing> IListingService.getAll()
        {
            var applicationDbContext = _context.Listings.Include(l => l.User);
            return applicationDbContext;
        }
    }
}
