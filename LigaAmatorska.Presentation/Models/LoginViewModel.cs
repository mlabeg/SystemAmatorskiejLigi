using System.ComponentModel.DataAnnotations;

namespace LigaAmatorska.Presentation.Models
{
    public class LoginViewModel
    {
        public static bool zalogowano = false;

        [Required(ErrorMessage = "Nazwa użytkownika jest wymagana")]
        public string NazwaUzytkownika { get; set; }

        [Required(ErrorMessage = "Hasło jest wymagane")]
        [DataType(DataType.Password)]
        public string Haslo { get; set; }
    }
}