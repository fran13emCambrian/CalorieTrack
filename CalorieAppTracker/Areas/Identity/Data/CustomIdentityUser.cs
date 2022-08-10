using Microsoft.AspNetCore.Identity;

namespace CalorieAppTracker.Areas.Identity.Data
{
    public class CustomIdentityUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
