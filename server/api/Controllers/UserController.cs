using fr.pierrejulien.ddit.api.Data;
using fr.pierrejulien.ddit.api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace fr.pierrejulien.ddit.api.Controllers;

[Route("users")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;
    private readonly IPasswordHasher<User> _passwordHasher = new PasswordHasher<User>();

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    [Route("login")]
    public async Task<ActionResult> Login(string username, string password)
    {
        try
        {
            _logger.LogInformation($"{username} try to login");

            using var context = new DditContext();
            var user = await context.Users.FirstAsync(x => x.Username == username);

            if (user == null)
                return NotFound("L'utilisateur demandé n'existe pas.");

            if (_passwordHasher.VerifyHashedPassword(user, user.Password, password) == PasswordVerificationResult.Failed)
                return Unauthorized($"Le mot de passe est incorrect.");

            return Ok("L'utilisateur a été connecté avec succès");
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                "L'utilisateur n'a pas pu être connecté. Ressayez dans quelques instants.");
        }
    }
}
