using System;
using System.Collections.Generic;

using Galaxia.Dominio;
using Galaxia.Dominio.Interface;
using Galaxia.Dados.Repositorio;
using Galaxia.Negocio.Abstracao;

namespace Galaxia.Negocio
{
    public class PlanetaNG : RepositorioNG<Planeta>
    {
        private PlanetaRepositorio _repositorio;
        public PlanetaNG()
        {
            _repositorio = new PlanetaRepositorio();
        }

        public override void Incluir(Planeta obj)
        {
            var retorno = base.getValidationErros(obj);
            var listaErro = string.Empty;

            foreach(var i in retorno)
            {
                listaErro += i.ErrorMessage + ";";
            }


            if (listaErro.Length > 0)
                throw new Exception("Erro: " + listaErro);

            base.Incluir(obj);
        }

        public List<Planeta> TrazerListaPlaneta()
        {
            return _repositorio.TrazerListaPlaneta();
        }
    }
}
