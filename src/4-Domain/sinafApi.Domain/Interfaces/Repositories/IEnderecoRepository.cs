using SinafApi.Domain.Models;

namespace SinafApi.Domain.Interfaces.Repositories
{
    public interface IEnderecoRepository : IBaseRepository<Endereco>
    {
        /// <summary>
        /// Cadastrar Endereco
        /// </summary>
        /// <param name="endereco">Endereco</param>
        /// <returns>void</returns>
        void Cadastrar(Endereco endereco);

        /// <summary>
        /// Atualizar Endereco
        /// </summary>
        /// <param name="endereco">Endereco</param>
        /// <returns>void</returns>
        void Atualizar(Endereco endereco);

        /// <summary>
        /// Busca Endereco
        /// </summary>
        /// <param name="endereco">Endereco</param>
        /// <returns>Endereco.</returns>
        Endereco BuscarEndereco(Endereco endereco);
    }
}
