using Microsoft.EntityFrameworkCore;
using RealEstateApp.Data.Entities;
using RealEstateApp.Entities;

namespace RealEstateApp.Data.DatabaseContext.ApplicationDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :  base(options)
        {

        }
        public DbSet<Property> Properties { get; set;}
        public DbSet<Contact> Contacts { get; set;}
    }
}