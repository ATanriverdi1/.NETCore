using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MarketingApp.WebUI.Models.identity;
using Microsoft.AspNetCore.Identity;

namespace MarketingApp.WebUI.Models
{
    public class RoleModel
    {
        [Required]
        public string RoleName { get; set; }
    }

    public class RoleDetails
    {
        public IdentityRole Role { get; set; }
        public IEnumerable<ApplicationUser> Members { get; set; }
        public IEnumerable<ApplicationUser> NonMembers { get; set; }
    }

    public class RoleEditModel
    {
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public string[] IdsToAdd { get; set; }
        public string[] IdsToDelete { get; set; }
    }
}