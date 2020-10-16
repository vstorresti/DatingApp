using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    //Body object sent through Request
    public class RegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}