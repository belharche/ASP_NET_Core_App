using Auction_ASP_Core.Models;

namespace Auction_ASP_Core.Data.Services
{
    public interface IListingService
    {
        IQueryable<Listing> getAll();
    }
}
