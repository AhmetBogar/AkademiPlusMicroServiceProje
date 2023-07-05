using System.ComponentModel.DataAnnotations;

namespace AkademiPlusMicroServiceProje.Frontend.Services.Abstract
{
    public class SignInInput
    {
        [Required]
        [Display(Name = "Email Adresi")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Şifre")]
        public string Password { get; set; }
        [Display(Name = "Beni Hatırla")]
        public bool IsRemember { get; set; }
    }
}
