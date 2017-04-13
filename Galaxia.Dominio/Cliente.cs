using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxia.Dominio
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Especie { get; set; }
        public string Documento { get; set; }
        public string Cor { get; set; }
        public int QtdBracos { get; set; }
        public int QtdPernas { get; set; }
        public int QtdCabecas { get; set; }
        public bool Respira { get; set; }
    }
}
