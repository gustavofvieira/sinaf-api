using SinafApi.Domain.Interfaces.Services;

namespace SinafApi.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> : IBaseService<TEntity> where TEntity : class
    {

    }
}
