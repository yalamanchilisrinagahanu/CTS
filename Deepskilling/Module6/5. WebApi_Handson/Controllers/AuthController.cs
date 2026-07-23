using JwtAuthApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JwtAuthApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private List<User> users = new()
        {
            new User
            {
                Id=1,
                Username="admin",
                Password="admin123",
                Role="Admin"
            }
        };

        [HttpPost("login")]
        public IActionResult Login(LoginModel login)
        {
            var user = users.FirstOrDefault(x =>
                x.Username == login.Username &&
                x.Password == login.Password);

            if (user == null)
                return Unauthorized("Invalid Username or Password");

            var claims = new[]
            {
                new Claim(ClaimTypes.Name,user.Username),
                new Claim(ClaimTypes.Role,user.Role)
            };

            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(
                _configuration["Jwt:Key"]!));

            var creds = new SigningCredentials(
                key,
                SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer:_configuration["Jwt:Issuer"],
                audience:_configuration["Jwt:Audience"],
                claims:claims,
                expires:DateTime.Now.AddHours(1),
                signingCredentials:creds);

            return Ok(new
            {
                token=new JwtSecurityTokenHandler().WriteToken(token)
            });
        }

        [Authorize]
        [HttpGet("profile")]
        public IActionResult Profile()
        {
            return Ok("Welcome Authorized User");
        }
    }
}
