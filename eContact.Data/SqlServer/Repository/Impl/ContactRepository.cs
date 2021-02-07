using eContact.Data.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Threading.Tasks;

//Note : This is not used since we are doing only CRUD operations which can be done with Generice repo
namespace eContact.Data.SqlServer.Repository
{
    public class ContactRepository : BaseRepository<Contact, ContactDBContext>, IContactRepository
    {

        private readonly ContactDBContext _dbContext;

        public ContactRepository(ContactDBContext context) : base(context)
        {
            _dbContext = context;
        }

        //added custom method for example to extend the repo
        public Task<List<Contact>> SearchContactAsync(string fname)
        {
            //example
            return _dbContext.Contact.Where(s => s.FirstName.StartsWith(fname)).ToListAsync();

        }
    }
}
