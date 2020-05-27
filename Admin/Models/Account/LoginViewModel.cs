using System.ComponentModel.DataAnnotations;

namespace Admin.Models.Account
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="E-poçt vacibdir!")]
        [EmailAddress(ErrorMessage ="Format düzgün deyil")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifrə vacibdir!")]
        [MinLength(6,ErrorMessage = "Şifrə uzunluğu 6 simvoldan çox olamlıdır")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
