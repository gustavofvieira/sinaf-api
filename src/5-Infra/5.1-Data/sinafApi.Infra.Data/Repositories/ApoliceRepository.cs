using SinafApi.Domain.Interfaces.Repositories;
using SinafApi.Domain.Models;
using SinafApi.Infra.Data.Context;
using System.Linq;

namespace SinafApi.Infra.Data.Repositories
{
    public class ApoliceRepository : BaseRepository<Apolice>, IApoliceRepository
    {
        public ApoliceRepository(DBSinafContext Db) : base(Db)
        {
            _Db = Db;
        }

        public void Cadastrar(Apolice apolice)
        {
            CheckContext();
            _Db.Apolices.Add(apolice);
            _Db.SaveChanges();
        }

        public void Atualizar(Apolice apolice)
        {
            CheckContext();
            _Db.Update(apolice);
            _Db.SaveChanges();
        }

        public Apolice BuscarApolice(Apolice apolice)
        {
            CheckContext();
            Apolice a = _Db.Apolices
                .FirstOrDefault(x => x.IdApolice == apolice.IdApolice);

            return a;
        }
    }
}
