using System.ComponentModel.DataAnnotations;

namespace SocialApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        [StringLength(32, MinimumLength = 4, ErrorMessage = "Your username must have from 4 to 32 characters")]
        public string Username { get; set; }

        [Required]
        [StringLength(16, MinimumLength = 4, ErrorMessage = "Your password must contain from 4 to 16 characters")]
        public string Password { get; set; }
    }
}