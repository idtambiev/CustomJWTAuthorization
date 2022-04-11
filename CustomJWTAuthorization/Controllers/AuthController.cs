using CustomJWTAuthorization.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace CustomJWTAuthorization.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        public AuthController()
        {
            
        }

        [HttpPost("registration")]
        public async Task<IActionResult> Registration()
        {
            return Ok();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login()
        {
            return Ok();
        }

        [HttpPost("refresh")]
        public async Task<IActionResult> RefreshToken()
        {
            return Ok();
        }

        [HttpPost("forgot-password-request")]
        public async Task<IActionResult> ForgotPasswordRequest()
        {
            return Ok();
        }

        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword()
        {
            return Ok();
        }

        private PasswordModel GeneratePasswordHash(string password)
        {
            using(var hmac = new HMACSHA512())
            {
                var passwordSalt = hmac.Key;
                var passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

                return new PasswordModel 
                { 
                    PasswordHash = passwordHash, 
                    PasswordSalt = passwordSalt 
                };

            }
        }

        private bool VerifyPasswordHash(string password, PasswordModel model)
        {
            using(var hmac = new HMACSHA512(model.PasswordSalt))
            {
                var computeHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computeHash.SequenceEqual(model.PasswordHash);
            }
        }
    }
}
