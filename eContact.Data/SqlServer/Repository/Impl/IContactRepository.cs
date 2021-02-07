using eContact.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eContact.Data.SqlServer.Repository
{
    //Note : This is not used since we are doing only CRUD operations which can be done with Generice repo
    public interface IContactRepository
    {
        Task<List<Contact>> SearchContactAsync(string fname);
    }
}