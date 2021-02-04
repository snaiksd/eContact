using eContact.Data.Entities;
using System;
using System.Collections.Generic;

namespace eContact.Services
{
    public interface IContactService
    {
        Contact GetContactDetail(int contactId);
        IEnumerable<Contact> GetContact();
        IEnumerable<Contact> GetContactById(int contactId);
    }
}
