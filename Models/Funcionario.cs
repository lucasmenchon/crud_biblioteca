
namespace crud_biblioteca.Models
{
    public class Funcionario
    {
        
        public int Id { get; set; }

        public string? Usuario { get; set; }

        public int Senha { get; set; }

        public string? Nome { get; set; }

        public string? Email { get; set; }

        public int Celular { get; set; }

        public string? Cargo { get; set; }

        public string? DataAdmissao { get; set; }

        public int Cpf { get; set; }

    }
}
