using eContact.Data.Entities;
using System;
using System.Collections.Generic;

namespace eContact.Services
{
    public interface IContactService
    {
        IEnumerable<Contact> GetContact();
        Contact GetContactById(int contactId);
        void DeleteContact(int contactId);
        void AddContact(Contact contact);
    }
}
