using fainting.Infrastucture.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace fainting.Infrastruture.Service
{
    public interface ILoginService
    {
        public Task<IActionResult> LoginAsync(LoginDto loginDto);
    }
}
