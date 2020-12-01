using System.ComponentModel.DataAnnotations;

namespace Api.Dtos
{
    public class UserForRegisterDto
    {
        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [StringLength(12, MinimumLength= 6, ErrorMessage="Password must be 6 to 12 characters long")]
        public string Password { get; set; }
    }
}