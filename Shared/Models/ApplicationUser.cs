global using Microsoft.AspNetCore.Identity;
namespace Shared.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AvatarUrl { get; set; }

        // Navigation Properties
        public virtual ICollection<Group> Groups { get; set; }
    }
}
