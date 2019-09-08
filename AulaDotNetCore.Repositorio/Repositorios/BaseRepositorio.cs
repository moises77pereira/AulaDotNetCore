using System.Collections.Generic;
using System.Linq;
using AulaDotNetCore.Dominio.Contratos;
using AulaDotNetCore.Repositorio.Contexto;

namespace AulaDotNetCore.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly AulaDotNetContexto AulaDotNetContexto;

        public BaseRepositorio(AulaDotNetContexto aulaDotNetContexto)
        {
            AulaDotNetContexto = aulaDotNetContexto;
        }

        public void Adicionar(TEntity entity)
        {
            AulaDotNetContexto.Set<TEntity>().Add(entity);
        }

        public void Atualizar(TEntity entity)
        {
            AulaDotNetContexto.Set<TEntity>().Update(entity);
            AulaDotNetContexto.SaveChanges();
        }
                
        public TEntity ObterPorId(int id)
        {
            return AulaDotNetContexto.Set<TEntity>().Find(id);     
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return AulaDotNetContexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            AulaDotNetContexto.Set<TEntity>().Remove(entity);
            AulaDotNetContexto.SaveChanges();
        }

        public void Dispose()
        {
            AulaDotNetContexto.Dispose();
        }
    }
}
