using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Galaxia.Dominio
{
    [Table("Planeta")]
    public class Planeta
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(50, MinimumLength = 1, ErrorMessage ="Até 50 caracteres e no minimo 1 caracter")]
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool PossuiOxigenio { get; set; }
    }
}
