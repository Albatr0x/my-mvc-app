using Microsoft.AspNetCore.Identity;
namespace my_mvc_app.Models
{
public class AccountViewModel : IdentityUser
{
    public new string Email { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }
     public bool RememberMe { get; set; }
}
}
