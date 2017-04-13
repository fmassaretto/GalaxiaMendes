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
            _repostorio.Alterar(obj);
        }

        public void Deletar(Planeta obj)
        {
            _repostorio.Deletar(obj);
        }

        public void Incluir(Planeta obj)
        {
            _repostorio.Incluir(obj);
        }

        public IEnumerable<Planeta> Selecionar()
        {
            return _repostorio.Selecionar();
        }

        public Planeta SelecionarPorId(int id)
        {
            return _repostorio.SelecionarPorId(id);
        }
    }
}
