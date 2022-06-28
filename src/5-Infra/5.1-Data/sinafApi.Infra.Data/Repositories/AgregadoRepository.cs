using SinafApi.Domain.Interfaces.Repositories;
using SinafApi.Domain.Models;
using SinafApi.Infra.Data.Context;
using System.Linq;

namespace SinafApi.Infra.Data.Repositories
{
    public class AgregadoRepository : BaseRepository<Agregado>, IAgregadoRepository
    {
        public AgregadoRepository(DBSinafContext Db) : base(Db)
        {
            _Db = Db;
        }

        public void Cadastrar(Agregado agregado)
        {
            CheckContext();
            _Db.Agregados.Add(agregado);
            _Db.SaveChanges();
        }

        public void Atualizar(Agregado agregado)
        {
            CheckContext();
            _Db.Update(agregado);
            _Db.SaveChanges();
        }

        public Agregado BuscarAgregado(Agregado agregado)
        {
            CheckContext();
            Agregado a = _Db.Agregados
                .FirstOrDefault(x => x.IdAgregado == agregado.IdAgregado);

            return a;
        }
    }
}
