using Galaxia.Dados.Repositorio;
using Galaxia.Dominio.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxia.Negocio.Abstracao
{
    public abstract class RepositorioNG<T> : IRepositorioBase<T> where T : class
    {
        private RepositorioBase<T> _repositorio;
        public RepositorioNG()
        {
            _repositorio = new RepositorioBase<T>();
        }

        public virtual void Alterar(T obj)
        {
            _repositorio.Alterar(obj);
        }

        public virtual void Deletar(T obj)
        {
            _repositorio.Deletar(obj);
        }

        public virtual void Incluir(T obj)
        {
            _repositorio.Incluir(obj);
        }

        public virtual IEnumerable<T> Selecionar()
        {
            return _repositorio.Selecionar();
        }

        public virtual T SelecionarPorId(int id)
        {
            return _repositorio.SelecionarPorId(id);
        }

        public virtual IEnumerable<ValidationResult> getValidationErros(object obj)
        {
            var resultadoValidacao = new List<ValidationResult>();
            var contexto = new ValidationContext(obj, null, null);
            Validator.TryValidateObject(obj, contexto, resultadoValidacao, true);

            return resultadoValidacao;
        }
    }
}
