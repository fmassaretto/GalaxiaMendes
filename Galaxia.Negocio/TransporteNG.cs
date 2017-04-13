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
    public class TransporteNG : IRepositorioBase<Transporte>
    {
        private RepositorioBase<Transporte> _repositorio;
        public TransporteNG()
        {
            _repositorio = new RepositorioBase<Transporte>();
        }
        public void Alterar(Transporte obj)
        {
            _repositorio.Alterar(obj);
        }

        public void Deletar(Transporte obj)
        {
            _repositorio.Deletar(obj);
        }

        public void Incluir(Transporte obj)
        {
            _repositorio.Incluir(obj);
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
