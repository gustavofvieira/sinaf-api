using SinafApi.Domain.Models;

namespace SinafApi.Domain.Interfaces.Repositories
{
    public interface IClienteRepository : IBaseRepository<Cliente>
    {
        /// <summary>
        /// Cadastrar Cliente
        /// </summary>
        /// <param name="Cliente">cliente</param>
        /// <returns>void</returns>
        void Cadastrar(Cliente cliente);

        /// <summary>
        /// Atualizar Cliente
        /// </summary>
        /// <param name="cliente">cliente</param>
        /// <returns>void</returns>
        void Atualizar(Cliente cliente);

        /// <summary>
        /// Busca Cliente
        /// </summary>
        /// <param name="cliente">Cliente</param>
        /// <returns>Cliente.</returns>
        Cliente BuscarCliente(Cliente cliente);
    }
}
