using fr.pierrejulien.ddit.api.Models;

namespace fr.pierrejulien.ddit.api.Services;

public interface IRedditService
{
    Task<IEnumerable<RedditModel>> Get();
}