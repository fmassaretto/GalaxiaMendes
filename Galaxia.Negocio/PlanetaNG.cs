using System;
using System.Collections.Generic;

using Galaxia.Dominio;
using Galaxia.Dominio.Interface;
using Galaxia.Dados.Repositorio;

namespace Galaxia.Negocio
{
    public class PlanetaNG : IRepositorioBase<Planeta>
    {
        private RepositorioBase<Planeta> _repostorio;
        public PlanetaNG()
        {
            _repostorio = new RepositorioBase<Planeta>();
        }
        public void Alterar(Planeta obj)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Planeta obj)
        {
            throw new NotImplementedException();
        }

        public void Incluir(Planeta obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Planeta> Selecionar()
        {
            return _repostorio.Selecionar();
        }

        public Planeta SelecionarPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
