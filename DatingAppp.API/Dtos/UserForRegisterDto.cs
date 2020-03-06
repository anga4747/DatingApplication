using System.ComponentModel.DataAnnotations;

namespace DatingAppp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Password needs to be between 4 and 8 charcters")]
        public string Password { get; set; }
    }
}