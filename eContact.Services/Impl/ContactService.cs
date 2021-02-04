using eContact.Data.Entities;
using eContact.Data.SqlServer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eContact.Services
{
    public class ContactService : IContactService
    {
        private readonly IBaseRepository<Contact> _contactRepository;

        public ContactService()
        {
            _contactRepository = new ContactRepository();
        }

        // DI - Dependency Injection
        public ContactService(IBaseRepository<Contact> contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public IEnumerable<Contact> GetContact()
        {
            return _contactRepository.Get();
        }

        public Contact GetContactDetail(int contactId)
        {
            return _contactRepository.GetByID(contactId);
        }

        public IEnumerable<Contact> GetContactById(int contactId)
        {
            return _contactRepository.Get().Where(c => c.ContactId == contactId).ToList();
        }

        public void SaveContact()
        {
            // Tempory added Unit Of Work Pattern.
            IUnitOfWork unitOfWork = null; // new ContactRepository();
            try
            {
                _contactRepository.SetUnitWork(unitOfWork);
                _contactRepository.Save();
                unitOfWork.CommitTransaction();
            }
            catch (Exception)
            {
                unitOfWork.RollBackTransaction();
                throw;
            }
        }
    }
}
