using fainting.Infrastucture.DTOs;
using fainting.Infrastucture.Reposities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Dynamic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace fainting.Infrastruture.Service
{
    public class LoginService(ILoginRepo loginRepo) : ControllerBase, ILoginService
    {
        public async Task<IActionResult> LoginAsync(LoginDto login)
        {
            var user = await loginRepo.GetUserByEmail(login.Email);
            if (user is null)
            {
                return Ok("Email Does not Exists");
            }
            else if (!BCrypt.Net.BCrypt.Verify(login.Password, user.Password))
            {
                return Ok("Invalid Password");
            }
            else
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Convert.FromBase64String("SGVsbG8sIFsdfmxkIQSGVsbG8sIFdvcmxkIQSGVsbG8sIFdvcmxkIWERVsbG8sIFdvccvbIW");
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                    new ("UserId", user.UserId.ToString()),
                    new ("Username", user.Username),
                    new ("Email", user.Email),
                    new ("Fullname", user.Fullname),
                    }),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };

                var token = tokenHandler.CreateToken(tokenDescriptor);
                dynamic token1 = new ExpandoObject();
                token1.token = tokenHandler.WriteToken(token);
                return Ok(token1);
            }
        }
    }
}
