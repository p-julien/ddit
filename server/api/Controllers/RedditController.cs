using fr.pierrejulien.ddit.api.Models;
using fr.pierrejulien.ddit.api.Services;
using Microsoft.AspNetCore.Mvc;

namespace fr.pierrejulien.ddit.api.Controllers;

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
    public async Task<IEnumerable<Reddit>> Get()
    {
        return await _redditService.Get();
    }
}
