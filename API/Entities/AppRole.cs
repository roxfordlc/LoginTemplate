using System;
using Microsoft.AspNetCore.Identity;

namespace API.Entities;

public class AppRole : IdentityRole<Guid>
{
    public ICollection<AppUserRole> UserRoles { get; set; } = [];
    public DateTime Created { get; } = DateTime.UtcNow;
}
