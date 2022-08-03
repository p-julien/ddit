using fr.pierrejulien.ddit.api.Data;
using fr.pierrejulien.ddit.api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace fr.pierrejulien.ddit.api.Controllers;

[Route("users")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public async Task<IEnumerable<User>> Get()
    {
        _logger.LogInformation("Get users is called");
        using var context = new DditContext();
        return await context.Users.ToListAsync();
    }
}
