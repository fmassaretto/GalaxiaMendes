using Galaxia.Dados.Contexto;
using Galaxia.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxia.Dados.Repositorio
{
    public class PlanetaRepositorio
    {
        GalaxiaContext _db;
        public PlanetaRepositorio()
        {
            _db = new GalaxiaContext();
        }

        public List<Planeta> TrazerListaPlaneta()
        {
            //var retorno = _db.Planeta.ToList();
            var retorno = from a in _db.Planeta
                          //INNER JOIN, vai aqui
                          where a.Id == 1
                          select a;
            return retorno.ToList();
        }
    }
}
