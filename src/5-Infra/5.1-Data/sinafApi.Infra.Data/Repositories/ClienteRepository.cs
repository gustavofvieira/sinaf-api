using SinafApi.Domain.Interfaces.Repositories;
using SinafApi.Domain.Models;
using SinafApi.Infra.Data.Context;
using System.Linq;

namespace SinafApi.Infra.Data.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(DBSinafContext Db) : base(Db)
        {
            _Db = Db;
        }

        public void Cadastrar(Cliente cliente)
        {
            CheckContext();
            _Db.Clientes.Add(cliente);
            _Db.SaveChanges();
        }

        public void Atualizar(Cliente cliente)
        {
            CheckContext();
            _Db.Update(cliente);
            _Db.SaveChanges();
        }

        public Cliente BuscarCliente(Cliente cliente)
        {
            CheckContext();
            Cliente c = _Db.Clientes
                .FirstOrDefault(x => x.IdCliente == cliente.IdCliente);

            return c;
        }
    }
}
