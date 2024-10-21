using Microsoft.AspNetCore.Identity;

namespace API.Entities;

public class AppUser: IdentityUser<Guid>
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public ICollection<AppUserRole> UserRoles { get; set; } = [];
}
