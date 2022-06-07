using System.ComponentModel.DataAnnotations.Schema;

namespace crud_biblioteca.Models
{
    [Table("Cliente")]
    public class Cliente
    {

        public int Id { get; set; }

        public string? Nome { get; set; }

        public string? Email { get; set; }

        public string? Celular { get; set; }

        public string? Telefone { get; set; }

        public string? CPF { get; set; }

    }
}
