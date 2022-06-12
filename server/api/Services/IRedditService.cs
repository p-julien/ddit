using api.Models;

namespace api.Services
{
    public interface IRedditService
    {
        IEnumerable<Reddit> Get();
    }
}
