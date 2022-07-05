using System.ComponentModel.DataAnnotations;

namespace Authorization.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage="Email Required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password Required")]
        public string Password { get; set; }
    }
}
