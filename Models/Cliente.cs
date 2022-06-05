using System.ComponentModel.DataAnnotations.Schema;

namespace crud_biblioteca.Models
{
    [Table("Cliente")]
    public class Cliente
    {

        public int Id { get; set; }

        public string? Nome { get; set; }

        public string? Email { get; set; }

        public int Celular { get; set; }

        public char Telefone { get; set; }

        public char CPF { get; set; }

    }
}
