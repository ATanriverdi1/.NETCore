using System.ComponentModel.DataAnnotations;

namespace MarketingApp.WebUI.Models
{
    public class ResetPasswordModel
    {
        [Required]
        public string Token { get; set; }

        [Required(ErrorMessage="Bu alan boş geçilemez")]
        [DataType(DataType.EmailAddress,ErrorMessage="Lütfen geçerli bir Email adresi giriniz")]
        public string Email { get; set; }

        [Required(ErrorMessage="Bu alan boş geçilemez")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage="Bu alan boş geçilemez")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string RePassword { get; set; }
    }
}