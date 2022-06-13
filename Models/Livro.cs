using System.ComponentModel.DataAnnotations;

namespace crud_biblioteca.Models
{
    public class Livro
    {

        public int Id { get; set; }

        [Display(Name = "Título")]
        //[Required(ErrorMessage = "Não é possível cadastrar sem um título.")]
        public string? Titulo { get; set; }

        [Display(Name = "Código")]
        public string? Codigo { get; set; }
                
        public string? Volume { get; set; }
            
        public string? Idioma { get; set; }

        [Display(Name = "Gênero")]
        public string? Genero { get; set; }

        [Display(Name = "Data da Publicação")]
        [DataType(DataType.Date)]
        [MaxLength(10, ErrorMessage = "Máximo de caracteres para data, favor colocar corretamente.")]        
        public string? DataPublicacao { get; set; }

        [Display(Name = "Edição")]
        public string? Edicao { get; set; }

        [Display(Name = "Data de Registro")]
        [DataType(DataType.Date)]
        [MaxLength(10, ErrorMessage = "Máximo de caracteres para data, favor colocar corretamente.")]
        public string? DataRegistro { get; set; }

        public string? Autor { get; set; }

        public string? Editora { get; set; }

        [Display(Name = "Descrição")]
        [MaxLength(255)]
        public string? Descricao { get; set; }

        //[Range(1, 100, ErrorMessage = "Limite de cadastro até 100.")]
        public int Quantidade { get; set; }

    }
}
