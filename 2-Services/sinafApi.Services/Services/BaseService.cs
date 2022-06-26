using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using SinafApi.Domain.Interfaces.Repositories;
using SinafApi.Domain.Interfaces.Services;

namespace SinafApi.Services.Services
{
    public class BaseService<TEntity> :  IBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _repository;
        

        public BaseService(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public IQueryable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return _repository.Buscar(predicate);
        }

        public bool Any(Expression<Func<TEntity, bool>> predicate)
        {
            return _repository.Any(predicate);
        }

        /// <summary>
        /// Salva o registro no banco e retorna o Id do registro gravado.
        /// </summary>
        /// <param name="obj">Objeto a ser Salvo.</param>
        /// <returns></returns>
        public TEntity Add(TEntity obj)
        {
            return _repository.Add(obj);
        }

        /// <summary>
        /// Obtem O registro de uma determinada entidade a partir do seu Id.
        /// </summary>
        /// <param name="id">Id da Entidade.</param>
        /// <returns></returns>
        public TEntity ObtemPorId(params object[] id)
        {
            return _repository.ObtemPorId(id);
        }

        /// <summary>
        /// Obtem uma lista de todos os registros de uma determinada entidade.
        /// </summary>
        /// <returns></returns>
        public IQueryable<TEntity> ObtemTodos()
        {
            return _repository.ObtemTodos();
        }

        /// <summary>
        /// Obtém a Entidade do Repositório Atual.
        /// </summary>
        /// <returns></returns>
        public DbSet<TEntity> Entity()
        {
            return _repository.Entity();
        }

        /// <summary>
        /// Deleta o registro fisicamente no banco de dados.
        /// </summary>
        /// <param name="obj">Objeto a ser excluído.</param>
        public void Remove(TEntity obj)
        {
            _repository.Remove(obj);
        }

        public void Remove(params object[] id)
        {
            _repository.Remove(id);
        }

        /// <summary>
        /// Atualiza o registro no banco de dados.
        /// </summary>
        /// <param name="obj">Objeto a ser atualizado.</param>
        public void Update(TEntity obj)
        {
            _repository.Update(obj);
        }

        public void Update(TEntity obj, params Expression<Func<TEntity, object>>[] properties)
        {
            _repository.Update(obj, properties);
        }

		TEntity IBaseService<TEntity>.GetBy(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes)
		{
            return _repository.GetBy(predicate, includes);
		}

		IEnumerable<TEntity> IBaseService<TEntity>.GetByToList(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes)
		{
            return _repository.GetByToList(predicate, includes);

        }

		IQueryable<TEntity> IBaseService<TEntity>.GetByAsQueryable(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes)
		{
            return _repository.GetByAsQueryable(predicate, includes);
		}

        Microsoft.EntityFrameworkCore.DbSet<TEntity> IBaseService<TEntity>.Entity()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}