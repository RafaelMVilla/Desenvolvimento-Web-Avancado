
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class Personagem
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Nome { get; set; }
        public string Tipo { get; set; }
    }
}