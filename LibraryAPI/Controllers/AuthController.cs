using LibraryAPI.Models;
using LibraryAPI.Repositories;
using LibraryAPI.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly JwtService _jwtService;
    private readonly IUserRepository _userRepository;

    public AuthController(JwtService jwtService, IUserRepository userRepository)
    {
        _jwtService = jwtService;
        _userRepository = userRepository;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest request)
    {
        var user = _userRepository.GetUserByUsername(request.Username);

        if (user == null || user.Password != request.Password)
        {
            return Unauthorized();
        }

        var token = _jwtService.GenerateToken(user.Username);
        return Ok(new { Token = token, Role = user.Role });
    }
}
