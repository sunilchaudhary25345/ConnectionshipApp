using Microsoft.AspNetCore.Identity;

namespace Situationships.API.Entities
{
    public class AppRole: IdentityRole<int>
    {
        public ICollection<AppUserRole> UserRoles { get; set; }
    }
}