using BCrypt.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace POS_WebAPI.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : Controller
    {
        private static User user = new User();
        private readonly IConfiguration _config;

        public AuthController(IConfiguration configuration)
        {
            _config = configuration;
        }

        [HttpPost("register")]
        public ActionResult<User> Register(UserCreateReq request)
        {
            var passwordHash = BCrypt.Net.BCrypt.HashPassword(request.Password);

            user.Username = request.Username;   
            user.PasswordHash = passwordHash;
            return Ok(user);    
        }

        [HttpPost("login")]
        public ActionResult<User> Login(UserCreateReq request)
        {
            if(user.Username != request.Username)
            {
                return BadRequest("Incorrect Username");
            }
            if (!BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash))
            {
                return BadRequest("Incorrect Password");
            }
            string token = CreateToken(user);
            //user.Token = token;
            return Ok(token);
        }

        private string CreateToken(User user)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("AppSettings:Token").Value!));

            var keySize = key.KeySize;
 
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Username),
            };

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds
            );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);
            return jwt;
        }


    }
}
