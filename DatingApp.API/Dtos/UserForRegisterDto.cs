using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(10, MinimumLength =3, ErrorMessage = "You must specify password between 3 and 10 characters")]
        public string Password { get; set; }
    }
}