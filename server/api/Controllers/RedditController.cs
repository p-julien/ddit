using fr.pierrejulien.ddit.api.Models;
using fr.pierrejulien.ddit.api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace fr.pierrejulien.ddit.api.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class RedditController : ControllerBase
{
    private readonly IRedditService _redditService;

    public RedditController(IRedditService redditService)
    {
        _redditService = redditService;
    }

    [HttpGet]
    public async Task<IEnumerable<RedditModel>> Get()
    {
        return await _redditService.Get();
    }
}
