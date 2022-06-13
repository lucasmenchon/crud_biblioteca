
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

        [EmailAddress]
        public string? Email { get; set; }

        [Phone]
        [MaxLength(11, ErrorMessage = "Um Número de Celular contém 11 números apenas, nem mais, nem menos!")]
        public string? Celular { get; set; }

        public string? Cargo { get; set; }

        [Display(Name = "Data de Admissão"), MaxLength(10)]
        [DataType(DataType.Date)]
        public string? DataAdmissao { get; set; }

        [MaxLength(11), MinLength(11, ErrorMessage = "Um CPF contém 11 números apenas, nem mais, nem menos!")]
        [Required(ErrorMessage = "Precisa cadastrar um CPF!")]
        public string? CPF { get; set;}

    }
}
