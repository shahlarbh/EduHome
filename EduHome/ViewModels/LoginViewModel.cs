using System.ComponentModel.DataAnnotations;

namespace EduHome.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
