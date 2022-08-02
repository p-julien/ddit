using api.Models;
using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("reddits")]
    [ApiController]
    public class RedditController : ControllerBase
    {
        private readonly IRedditService _redditService;

        public RedditController(IRedditService redditService)
        {
            _redditService = redditService;
        }

        [HttpGet]
        public async Task<IEnumerable<Reddit>> Get() => await _redditService.Get();
    }
}
