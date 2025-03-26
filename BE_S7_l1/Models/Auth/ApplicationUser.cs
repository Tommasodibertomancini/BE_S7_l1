using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BE_S7_l1.Models.Auth
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public required string FirstName { get; set; }

        [Required]
        public required string LastName { get; set; }

        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
