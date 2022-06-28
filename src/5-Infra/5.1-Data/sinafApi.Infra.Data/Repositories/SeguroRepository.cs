using SinafApi.Domain.Interfaces.Repositories;
using SinafApi.Domain.Models;
using SinafApi.Infra.Data.Context;
using System.Linq;

namespace SinafApi.Infra.Data.Repositories
{
    public class SeguroRepository : BaseRepository<Seguro>, ISeguroRepository
    {
        public SeguroRepository(DBSinafContext Db) : base(Db)
        {
            _Db = Db;
        }

        public void Cadastrar(Seguro seguro)
        {
            CheckContext();
            _Db.Seguros.Add(seguro);
            _Db.SaveChanges();
        }

        public void Atualizar(Seguro seguro)
        {
            CheckContext();
            _Db.Update(seguro);
            _Db.SaveChanges();
        }

        public Seguro BuscarSeguro(Seguro seguro)
        {
            CheckContext();
            Seguro s = _Db.Seguros
                .FirstOrDefault(x => x.IdSeguro == seguro.IdSeguro);

            return s;
        }
    }
}
