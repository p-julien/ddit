using api.Models;

namespace api.Services;

public interface IRedditService
{
    Task<IEnumerable<Reddit>> Get();
}