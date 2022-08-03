using fr.pierrejulien.ddit.api.Data;
using fr.pierrejulien.ddit.api.Models;
using Microsoft.EntityFrameworkCore;

namespace fr.pierrejulien.ddit.api.Services.Implementation;

public class RedditService : IRedditService
{
    public async Task<IEnumerable<Reddit>> Get()
    {
        using var context = new DditContext();
        return await context.Reddits.ToListAsync();
    }
}
