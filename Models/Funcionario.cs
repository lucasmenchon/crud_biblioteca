
using System.ComponentModel.DataAnnotations;

namespace crud_biblioteca.Models
{
    public class Funcionario
    {
        
        public int Id { get; set; }

        public string? Usuario { get; set; }

        public string? Senha { get; set; }

        public string? Nome { get; set; }

        public string? Email { get; set; }

        public int Celular { get; set; }

        public string? Cargo { get; set; }

        [Display(Name = "Data de Admissão")]
        [DataType(DataType.Date)]
        public string? DataAdmissao { get; set; }

        //[MaxLength,MinLength(11, ErrorMessage = "O CPF precisa de 11 números!")]
        [Required(ErrorMessage = "Precisa cadastrar um CPF!")]
        public char CPF { get; set;}


    }
}
