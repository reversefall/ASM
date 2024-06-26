using Microsoft.AspNetCore.Identity;

namespace ASM.Models
{
    public class ApplicationRole : IdentityRole
    {
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }

    }
}
