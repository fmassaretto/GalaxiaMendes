using Galaxia.Dados.Repositorio;
using Galaxia.Dominio;
using Galaxia.Dominio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxia.Negocio
{
    class TransporteNG : IRepositorioBase<Transporte>
    {
        private RepositorioBase<Transporte> _repositorio;
        public TransporteNG()
        {
            _repositorio = new RepositorioBase<Transporte>();
        }
        public void Alterar(Transporte obj)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Transporte obj)
        {
            throw new NotImplementedException();
        }

        public void Incluir(Transporte obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Transporte> Selecionar()
        {
            return _repositorio.Selecionar();
        }

        public Transporte SelecionarPorId(int id)
        {
            return _repositorio.SelecionarPorId(id);
        }
    }
}
