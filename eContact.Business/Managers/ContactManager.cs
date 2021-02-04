using eContact.Data.Entities;
using eContact.Data.SqlServer.Repository;
using eContact.Services;
using System;
using System.Collections.Generic;

namespace eContact.Business.Managers
{
    public class ContactManager
    {
        private IContactService _ContactService;

        // Can Implement DI for IContact ContactService
        public ContactManager()
        {
            _ContactService = new ContactService();
        }

        public void DeleteContact(int contactId)
        {
            _ContactService.DeleteContact(contactId);
        }

        public void AddContact(Contact contact)
        {
            _ContactService.AddContact(contact);
        }

        public void EditContact(Contact contact)
        {
            _ContactService.AddContact(contact);
        }

        public IEnumerable<Contact> GetContacts()
        {
            return _ContactService.GetContact();
        }

        public Contact GetContactById(int contactId)
        {
            return _ContactService.GetContactById(contactId);
        }

        public void SaveContact()
        {
        }
    }
}
