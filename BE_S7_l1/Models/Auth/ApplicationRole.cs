using Microsoft.AspNetCore.Identity;

namespace BE_S7_l1.Models.Auth
{
    public class ApplicationRole : IdentityRole
    {
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
    
}
