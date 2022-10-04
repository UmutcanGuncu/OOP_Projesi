using System.ComponentModel.DataAnnotations;

namespace Demo_Product.Models
{
    public class UserEditViewModel
    {
        [Required(ErrorMessage = "Lütfen Adınızı Giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Soyadınızı Giriniz")]
        public string SurName { get; set; }
        
        [Required(ErrorMessage = "Lütfen E Posta Adresinizi Giriniz")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Lütfen Cinsiyet Seçiniz")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi Tekrar Giriniz")]
        [Compare("Password", ErrorMessage = "Lütfen Şifrelerin Eşleştiğinden Emin Olunuz")]
        public string ConfirmPassword { get; set; }
    }
}
