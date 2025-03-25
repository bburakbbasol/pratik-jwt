using Microsoft.AspNetCore.Identity;

namespace pratik_jwt.Model
{
    public class User : IdentityUser
    {
        public int Id { get; set; }
        public string Email { get; set; }
    }
}
