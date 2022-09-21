using System.ComponentModel.DataAnnotations;

namespace FilmeAPI.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O Campo título é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O Campo diretor é obrigatório")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O gênero deve conter no mínimo 3 e máximo 30 caracteres", MinimumLength = 3)]
        public string Genero { get; set; }
        [Range(5, 200, ErrorMessage = "A duração deve ter no mínimo 1 e no máixmo 200 minutos")]
        public int Duracao { get; set; }
    }
}
