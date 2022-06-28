using SinafApi.Domain.Models;

namespace SinafApi.Domain.Interfaces.Repositories
{
    public interface IAgregadoRepository : IBaseRepository<Agregado>
    {
        /// <summary>
        /// Cadastrar Agregado
        /// </summary>
        /// <param name="agregado">Agregado</param>
        /// <returns>void</returns>
        void Cadastrar(Agregado agregado);

        /// <summary>
        /// Atualizar Agregado
        /// </summary>
        /// <param name="agregado">Agregado</param>
        /// <returns>void</returns>
        void Atualizar(Agregado agregado);

        /// <summary>
        /// Busca Agregado
        /// </summary>
        /// <param name="agregado">Agregado</param>
        /// <returns>Agregado.</returns>
        Agregado BuscarAgregado(Agregado agregado);
    }
}
