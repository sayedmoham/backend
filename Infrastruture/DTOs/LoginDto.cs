using System.ComponentModel.DataAnnotations;

namespace fainting.Infrastucture.DTOs
{
    public class LoginDto
    {
        [Required]
        public string Email { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
    }

    //public class ForgetPasswordDto
    //{
    //    [Required]
    //    public string Email { get; set; } = null!;
    //}

    //public class ResetPasswordDto
    //{
    //    [Required]
    //    public int UserId { get; set; } = default!;
    //    [Required]
    //    public string NewPassword { get; set; } = null!;
    //}
}
