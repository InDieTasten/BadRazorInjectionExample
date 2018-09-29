using Microsoft.AspNetCore.Identity;

namespace StackOverflowExample
{
    public class MyUserStore : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}