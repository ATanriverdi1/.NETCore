using Microsoft.AspNetCore.Identity;

namespace MarketingApp.WebUI.Models.identity
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}