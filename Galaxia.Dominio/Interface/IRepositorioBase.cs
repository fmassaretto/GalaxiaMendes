using System.Collections.Generic;

namespace Galaxia.Dominio.Interface
{
    public interface IRepositorioBase<TEntity> where TEntity : class
    {
        void Incluir(TEntity obj);
        TEntity SelecionarPorId(int id);
        IEnumerable<TEntity> Selecionar();
        void Alterar(TEntity obj);
        void Deletar(TEntity obj);
    }
}
