using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BE_S7_l1.Models.Auth
{
    public class ApplicationUserRole : IdentityUserRole<string>
    {
        [Required]
        public Guid UserId { get; set; }

        [Required]
        public Guid RoleId { get; set; }

        
        [ForeignKey(nameof(UserId))]
        public ApplicationUser ApplicationUser { get; set; }

        [ForeignKey(nameof(RoleId))]
        public ApplicationRole ApplicationRole { get; set; }
    }
}
