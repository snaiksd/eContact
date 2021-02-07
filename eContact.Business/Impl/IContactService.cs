using eContact.Data.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eContact.Services
{
    public interface IContactService
    {
        Task<List<Contact>> GetContact();
        Task<Contact> GetContactById(int contactId);
        void DeleteContact(int contactId);
        void AddContact(Contact contact);
        int UpdateContact(Contact contact);
    }
}
