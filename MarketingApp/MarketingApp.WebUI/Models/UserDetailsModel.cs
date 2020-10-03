using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MarketingApp.WebUI.Models
{
    public class UserDetailsModel
    {
        public string UserId { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }

        public IEnumerable<string> SelectedRoles { get; set; }
    }
}