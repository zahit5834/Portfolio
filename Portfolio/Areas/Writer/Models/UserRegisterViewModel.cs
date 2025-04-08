using System.ComponentModel.DataAnnotations;

namespace Portfolio.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen Adını Giriniz")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Lütfen Soyadını Giriniz")]
        public string Surname { get; set; } = string.Empty;
        [Required(ErrorMessage ="Lütfen Kullanıcı Adını Giriniz")]
        public string UserName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Lütfen Görseli Yükleyiniz")]
        public string ImageUrl { get; set; } = string.Empty;
        [Required(ErrorMessage = "Lütfen Şifreyi Giriniz")]
        public string Password { get; set; } = string.Empty;
        [Required(ErrorMessage = "Lütfen Şifreyi Tekrar Giriniz")]
        [Compare("Password", ErrorMessage = "Şifreler Uyuşmuyor")]
        public string ConfirmPassword { get; set; } = string.Empty;
        [Required(ErrorMessage = "Lütfen Mail Giriniz")]
        public string Mail { get; set; } = string.Empty;
    }
}
