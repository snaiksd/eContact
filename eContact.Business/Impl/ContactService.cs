using eContact.Data.Entities;
using eContact.Data.SqlServer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eContact.Services
{
    //Using BasReo but as we need more customiztion we can use different repo with their own methods only
    public class ContactService : IContactService
    {
        private readonly IBaseRepository<Contact> _contactRepository;

        // DI - Dependency Injection
        public ContactService(IBaseRepository<Contact> contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public Task<List<Contact>> GetContact()
        {
            return _contactRepository.GetAllAsync();
        }

        public Task<Contact> GetContactById(int contactId)
        {
            return _contactRepository.GetAsync(contactId);
        }

        public void DeleteContact(int contactId)
        {
             _contactRepository.Delete(contactId);
        }

        public void AddContact(Contact contact)
        {
            _contactRepository.AddAsync(contact);
        }

        public int UpdateContact(Contact contact)
        {
            return _contactRepository.Update(contact);
        }
    }
}
