namespace crud_biblioteca.Models
{
    public class Livro
    {

        public int Id { get; set; }

        public string Titulo { get; set; }

        public int Codigo { get; set; }

        public int Volume { get; set; }

        public string Idioma { get; set; }

        public string Genero { get; set; }

        public string DataPublicacao { get; set; }

        public string Edicao { get; set; }

        public string DataRegistro { get; set; }

        public string Autor { get; set; }

        public string Editora { get; set; }

        public string Descricao { get; set; }

        public int Quantidade { get; set; }

    }
}
