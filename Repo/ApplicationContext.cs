
using Data.Entities;
using Data.EntitiesConfigurtion;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;

namespace Repo
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.ApplyConfigurationsFromAssembly(typeof(CategoryConfigurationcs).Assembly);
            builder.seed();  // data in tables first time 
        }
        public DbSet<Category> Products { get; set; }
        public DbSet<Product> Categories { get; set; }
   


    }
    public class ApplicationUser : IdentityUser
    {
        public string RefreshToken { get; set; }

    }

}
