using Microsoft.AspNetCore.Identity;

namespace CalorieAppTrack.Areas.Identity.Data
{
    public class CustomIdentityUser : IdentityUser 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
