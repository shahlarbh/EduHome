using Microsoft.AspNetCore.Identity;

namespace EduHome.DataAccessLayer.Entity
{
    public class User : IdentityUser
    {
        public string? Fullname { get; set; }
    }
}
