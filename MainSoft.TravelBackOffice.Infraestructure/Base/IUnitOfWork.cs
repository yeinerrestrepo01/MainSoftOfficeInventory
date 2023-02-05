using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace MainSoft.TravelBackOffice.Infraestructure.Base
{

    public interface IUnitOfWork : IDisposable
    {
        int Commit();

        Task<int> CommitAsync();


        List<Q> RawSqlQuery<Q>(string query, Func<DbDataReader, Q> map);
        DbContext getContext();
    }
}
