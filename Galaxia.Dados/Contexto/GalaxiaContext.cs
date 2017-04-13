using Galaxia.Dominio;
using System.Data.Entity;

namespace Galaxia.Dados.Contexto
{
    public class GalaxiaContext : DbContext
    {
        public GalaxiaContext()
            : base("Default")
        {

        }

        public DbSet<Planeta> Planeta { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Transporte> Transporte { get; set; }
    }
}
