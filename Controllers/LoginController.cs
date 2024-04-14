using fainting.Infrastruture.Service;
using fainting.Infrastucture.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace fainting.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController(ILoginService loginService) : ControllerBase
    {

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        {
            return await loginService.LoginAsync(loginDto);
        }
    }
}
