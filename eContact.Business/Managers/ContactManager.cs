using eContact.Data.Entities;
using eContact.Data.SqlServer.Repository;
using eContact.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eContact.Business.Managers
{
    public class ContactManager
    {
        private IContactService _ContactService;

        // Can Implement DI for IContact ContactService
        public ContactManager(IContactService ctService)
        {
            _ContactService = ctService;
        }

        public ContactManager()
        {
        }

        public Task<List<Contact>> GetContacts()
        {
            return _ContactService.GetContact();
        }

        public void DeleteContact(int contactId)
        {
            _ContactService.DeleteContact(contactId);
        }

        public void AddContact(Contact contact)
        {
            _ContactService.AddContact(contact);
        }

        public int EditContact(Contact contact)
        {
            return _ContactService.UpdateContact(contact);
        }

        public Task<Contact> GetContactById(int contactId)
        {
            return _ContactService.GetContactById(contactId);
        }

        public void SaveContact()
        {
        }
    }
}
