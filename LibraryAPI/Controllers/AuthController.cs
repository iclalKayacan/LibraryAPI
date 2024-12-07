using Microsoft.AspNetCore.Mvc;
using LibraryAPI.Services; 
using LibraryAPI.Data;     
using LibraryAPI.Models;   
using System.Linq;

namespace LibraryAPI.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly JwtService _jwtService;
        private readonly ApplicationDbContext _context;

        public AuthController(JwtService jwtService, ApplicationDbContext context)
        {
            _jwtService = jwtService;
            _context = context;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            var user = _context.Users.SingleOrDefault(u => u.Username == request.Username && u.Password == request.Password);

            if (user != null)
            {
                var token = _jwtService.GenerateToken(user.Username);
                return Ok(new { Token = token, Role = user.Role });
            }

            return Unauthorized();
        }
    }
}
