using Microsoft.AspNetCore.Identity;

namespace CalorieTrackerApp.Areas.Identity.Data
{
    public class CustomIdentityUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }    

    }
}
