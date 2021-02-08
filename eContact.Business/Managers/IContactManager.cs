using eContact.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eContact.Business.Managers
{
    public interface IContactManager
    {
        void AddContact(Contact contact);
        void DeleteContact(int contactId);
        int EditContact(Contact contact);
        Task<Contact> GetContactById(int contactId);
        Task<List<Contact>> GetContacts();
        void SaveContact();
    }
}