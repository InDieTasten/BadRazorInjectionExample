using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace StackOverflowExample
{
    public class ApplicationDbContext : IdentityDbContext<MyUserStore, MyUserRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>
          options) : base(options)
        {
        }
    }
}