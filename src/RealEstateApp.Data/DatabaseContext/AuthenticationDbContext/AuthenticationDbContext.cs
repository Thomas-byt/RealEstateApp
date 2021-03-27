using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RealEstateApp.Data.Entities;

namespace RealEstateApp.Data.DatabaseContext.AuthenticationDbContext
{
    public class AuthenticationDbContext: IdentityDbContext <ApplicationUser>
    {
    public AuthenticationDbContext(DbContextOptions<AuthenticationDbContext>options): base(options)
    {

    }
    }
}