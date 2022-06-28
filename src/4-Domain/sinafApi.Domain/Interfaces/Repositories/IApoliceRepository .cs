using SinafApi.Domain.Models;

namespace SinafApi.Domain.Interfaces.Repositories
{
    public interface IApoliceRepository : IBaseRepository<Apolice>
    {
        /// <summary>
        /// Cadastrar Apolice
        /// </summary>
        /// <param name="apolice">Apolice</param>
        /// <returns>void</returns>
        void Cadastrar(Apolice apolice);

        /// <summary>
        /// Atualizar Apolice
        /// </summary>
        /// <param name="apolice">Apolice</param>
        /// <returns>void</returns>
        void Atualizar(Apolice apolice);

        /// <summary>
        /// Busca Apolice
        /// </summary>
        /// <param name="apolice">Apolice</param>
        /// <returns>Apolice.</returns>
        Apolice BuscarApolice(Apolice apolice);
    }
}
