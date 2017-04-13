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
    public class ViagemNG : IRepositorioBase<Viagem>
    {
        private RepositorioBase<Viagem> _repositorio;
        public ViagemNG()
        {
            _repositorio = new RepositorioBase<Viagem>();
        }
        public void Alterar(Viagem obj)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Viagem obj)
        {
            throw new NotImplementedException();
        }

        public void Incluir(Viagem obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Viagem> Selecionar()
        {
            throw new NotImplementedException();
        }

        public Viagem SelecionarPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
