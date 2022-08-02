using api.Contexts;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Services.Implementation;

public class RedditService : IRedditService
{
    public async Task<IEnumerable<Reddit>> Get() 
    {
        using var context = new DditContext();
        return await context.Reddits.ToListAsync();
    }
}
