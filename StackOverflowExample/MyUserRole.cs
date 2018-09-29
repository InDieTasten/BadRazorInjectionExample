using Microsoft.AspNetCore.Identity;

namespace StackOverflowExample
{
    public class MyUserRole : IdentityRole
    {
        public string Description { get; set; }
    }
}