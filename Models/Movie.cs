using System.ComponentModel.DataAnnotations;

namespace MovieAPI.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O diretor é obrigatório")]
        public string Director { get; set; }

        [Range(20, 300, ErrorMessage = "Digite um valor válido")]
        public int Duration { get; set; }

        public string Genre { get; set; }

    }

}