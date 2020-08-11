using Microsoft.AspNetCore.Identity;

namespace Core.Enteties.Identity
{
    public class AppUser : IdentityUser
    {
        public string DisplyName { get; set; }
        public Address Address { get; set; }
    }
}
