using SinafApi.Domain.Models;

namespace SinafApi.Domain.Interfaces.Repositories
{
    public interface ISeguroRepository : IBaseRepository<Seguro>
    {
        /// <summary>
        /// Cadastrar Seguro
        /// </summary>
        /// <param name="seguro">Seguro</param>
        /// <returns>void</returns>
        void Cadastrar(Seguro seguro);

        /// <summary>
        /// Atualizar Seguro
        /// </summary>
        /// <param name="seguro">Seguro</param>
        /// <returns>void</returns>
        void Atualizar(Seguro seguro);

        /// <summary>
        /// Busca Seguro
        /// </summary>
        /// <param name="Seguro">Seguro</param>
        /// <returns>Seguro.</returns>
        Seguro BuscarSeguro(Seguro seguro);
    }
}
