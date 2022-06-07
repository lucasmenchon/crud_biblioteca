using Microsoft.EntityFrameworkCore;

namespace crud_biblioteca.Models
{
    public class Context : DbContext
    {

        public Context(DbContextOptions<Context> options) : base(options)

        {
            
        }

        public DbSet<Livro>? Livros { get; set; }

        public DbSet<Reserva>? Reservas { get; set; }

        public DbSet<Cliente>? Clientes { get; set; }

        public DbSet<Funcionario>? Funcionarios { get; set; }

    }
}
