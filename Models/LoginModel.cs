using System.ComponentModel.DataAnnotations;

namespace crud_biblioteca.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite um email.")]
        public string? Login { get; set; }

        [Required(ErrorMessage = "Digite uma senha.")]
        public string? Senha { get; set; }
    }
}
