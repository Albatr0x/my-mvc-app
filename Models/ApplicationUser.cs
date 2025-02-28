using Microsoft.AspNetCore.Identity;

namespace my_mvc_app.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Additional properties can be added here
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}