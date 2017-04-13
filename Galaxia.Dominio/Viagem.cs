using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxia.Dominio
{
    [Table("Viagem")]
    public class Viagem
    {
        [Key]
        public int Id { get; set; }
        public string PlanetaOrigem { get; set; }
        public string PlanetaDestino { get; set; }
        public double Valor { get; set; }
        public int Tempo { get; set; }
    }
}
