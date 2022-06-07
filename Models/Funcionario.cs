
using System.ComponentModel.DataAnnotations;

namespace crud_biblioteca.Models
{
    public class Funcionario
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite um usuário para login")]
        public string? Usuario { get; set; }
        [Required(ErrorMessage = "Digite uma senha para login")]
        public string? Senha { get; set; }

        public string? Nome { get; set; }

        public string? Email { get; set; }

        public string? Celular { get; set; }

        public string? Cargo { get; set; }

        [Display(Name = "Data de Admissão")]
        [DataType(DataType.Date)]
        public DateTime DataAdmissao { get; set; }

        //[MaxLength,MinLength(11, ErrorMessage = "O CPF precisa de 11 números!")]
        [Required(ErrorMessage = "Precisa cadastrar um CPF!")]
        public string? CPF { get; set;}

    }
}
