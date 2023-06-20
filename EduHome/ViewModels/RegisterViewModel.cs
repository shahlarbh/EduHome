using System.ComponentModel.DataAnnotations;

namespace EduHome.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string Username { get; set; }

        public string? Fullname { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
