using crud_biblioteca.Models;
using System.ComponentModel.DataAnnotations;

namespace crud_biblioteca.Models
{
    public class Reserva
    {
        public int Id { get; set; }

        [Display(Name = "Data de Reserva")]
        [DataType(DataType.Date)]
        public string? DataReserva { get; set; }

        [Display(Name = "Data de Entrega")]
        [DataType(DataType.Date)]
        public string? DataEntrega { get; set; }

        [Display(Name = "Cliente")]
        public string? NomeCliente { get; set; } 

        [Display(Name = "Código do Livro")]
        public string? CodigoLivro { get; set; }

    }
}
