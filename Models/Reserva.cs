using crud_biblioteca.Models;

namespace crud_biblioteca.Models
{
    public class Reserva
    {
        public int Id { get; set; }


        public string? DataReserva { get; set; }

        public string? DataEntrega { get; set; }

        public string? NomeCliente { get; set; }

        public int CodigoLivro { get; set; }
        

    }
}
