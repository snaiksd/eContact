using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace eContact.Data.SqlServer.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        void Insert(T entity);
        IEnumerable<T> Get();
        IEnumerable Get(IDbCommand dbCommand);
        IEnumerable GetWithRawSql(string query, params object[] parameters);
        void Update(T entityToUpdate);
        T GetByID(int id);
        void Delete(T entityToDelete);
        void Delete(int id);
        void Save();
        void SetUnitWork(IUnitOfWork unitOfWork);
    }
}
