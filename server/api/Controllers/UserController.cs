using api.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[Route("users")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IEnumerable<User> _users = new List<User>
    {
        new User { Id = 1, Name = "href404" },
        new User { Id = 2, Name = "CodeM" },
        new User { Id = 3, Name = "Zackan" },
        new User { Id = 4, Name = "LYX" },
    };

    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public Task<IEnumerable<User>> Get()
    {
        _logger.LogInformation("Get users is called");
        return Task.FromResult(_users);
    }
}
