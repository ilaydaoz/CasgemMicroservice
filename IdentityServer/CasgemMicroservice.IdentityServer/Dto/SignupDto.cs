using System.ComponentModel.DataAnnotations;

namespace CasgemMicroservice.IdentityServer.Dto
{
    public class SignupDto
    {
        [Required]
        public string NameSurne  { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
