using SinafApi.Domain.Interfaces.Repositories;
using SinafApi.Domain.Models;
using SinafApi.Infra.Data.Context;
using System.Linq;

namespace SinafApi.Infra.Data.Repositories
{
    public class EnderecoRepository : BaseRepository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(DBSinafContext Db) : base(Db)
        {
            _Db = Db;
        }

        public void Cadastrar(Endereco endereco)
        {
            CheckContext();
            _Db.Enderecos.Add(endereco);
            _Db.SaveChanges();
        }

        public void Atualizar(Endereco endereco)
        {
            CheckContext();
            _Db.Update(endereco);
            _Db.SaveChanges();
        }

        public Endereco BuscarEndereco(Endereco endereco)
        {
            CheckContext();
            Endereco e = _Db.Enderecos
                .FirstOrDefault(x => x.IdEndereco == endereco.IdEndereco);

            return e;
        }
    }
}
