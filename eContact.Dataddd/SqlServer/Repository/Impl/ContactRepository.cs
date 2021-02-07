using eContact.Data.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace eContact.Data.SqlServer.Repository
{
    public class ContactRepository : BaseRepository<Contact>
    {
        List<Contact> Contact = new List<Contact>();

        // TODO : I wanted to implement DI here, mostly UnitOfWork for calling one repository into anoter reposotiry
        private readonly ContactDBContext _dbContext;

        public ContactRepository(ContactDBContext context) : base(context)
        {
            _dbContext = context;
        }

        public void Delete(Contact entityToDelete)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable Get(IDbCommand dbCommand)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Contact>> GetAll()
        {
            return GetContacts();
        }

        public Contact GetByID(int id)
        {
            return Contact.Where(n => n.ContactId == id).FirstOrDefault();
        }

        public IEnumerable GetWithRawSql(string query, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public void Insert(Contact entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void SetUnitWork(IUnitOfWork unitOfWork)
        {
            throw new NotImplementedException();
        }

        public void Update(Contact entityToUpdate)
        {
            throw new NotImplementedException();
        }


        #region Private 

        private List<Contact> GetContacts()
        {
            /*ContactsCategoryRepository _categoryRepository = new ContactsCategoryRepository();
            ContactsCategory category1 = _categoryRepository.GetContactsCategory((short)ContactsCategoryType.Political);
            ContactsCategory category2 = _categoryRepository.GetContactsCategory((short)ContactsCategoryType.Sports);
            ContactsCategory category3 = _categoryRepository.GetContactsCategory((short)ContactsCategoryType.Travel);
            ContactsCategory category4 = _categoryRepository.GetContactsCategory((short)ContactsCategoryType.Entertainment);
            ContactsCategory category5 = _categoryRepository.GetContactsCategory((short)ContactsCategoryType.Advertisements);

            List<Contact> Contact = new List<Contact>() {
                new Contact
                {
                     ContactsId = Guid.NewGuid(),
                     Category = category1,
                     Title = "Headline 1",
                     Content = "Contact 1",
                     PublishedDate = DateTime.UtcNow,
                     ReportedDate = DateTime.UtcNow,
                     UpdatedDate = null,
                     Reporter = new ContactsReporter
                     {
                        ReportedId = 1,
                        FirstName = "fName",
                        LastName = "lName"
                     }
                },
                new Contact
                {
                     ContactsId = Guid.NewGuid(),
                     Category = category2,
                     Title = "Headline 2",
                     Content = "Contact 2",
                     PublishedDate = DateTime.UtcNow,
                     ReportedDate = DateTime.UtcNow,
                     UpdatedDate = null,
                     Reporter = new ContactsReporter
                     {
                        ReportedId = 2,
                        FirstName = "fName",
                        LastName = "lName"
                     }
                },
                new Contact
                {
                     ContactsId = Guid.NewGuid(),
                     Category = category3,
                     Title = "Headline 3",
                     Content = "Contact 3",
                     PublishedDate = DateTime.UtcNow,
                     ReportedDate = DateTime.UtcNow,
                     UpdatedDate = null,
                     Reporter = new ContactsReporter
                     {
                        ReportedId = 1,
                        FirstName = "fName",
                        LastName = "lName"
                     }
                },
                new Contact
                {
                     ContactsId = Guid.NewGuid(),
                     Category = category4,
                     Title = "Headline 4",
                     Content = "Contact 4",
                     PublishedDate = DateTime.UtcNow,
                     ReportedDate = DateTime.UtcNow,
                     UpdatedDate = null,
                     Reporter = new ContactsReporter
                     {
                        ReportedId = 3,
                        FirstName = "fName",
                        LastName = "lName"
                     }
                },
                new Contact
                {
                     ContactsId = Guid.NewGuid(),
                     Category = category1,
                     Title = "Headline 5",
                     Content = "Contact 5",
                     PublishedDate = DateTime.UtcNow,
                     ReportedDate = DateTime.UtcNow,
                     UpdatedDate = null,
                     Reporter = new ContactsReporter
                     {
                        ReportedId = 1,
                        FirstName = "fName",
                        LastName = "lName"
                     }
                },
                new Contact
                {
                     ContactsId = Guid.NewGuid(),
                     Category = category1,
                     Title = "Headline 6",
                     Content = "Contact 6",
                     PublishedDate = DateTime.UtcNow,
                     ReportedDate = DateTime.UtcNow,
                     UpdatedDate = null,
                     Reporter = new ContactsReporter
                     {
                        ReportedId = 1,
                        FirstName = "fName",
                        LastName = "lName"
                     }
                },
                new Contact
                {
                     ContactsId = Guid.NewGuid(),
                     Category = category1,
                     Title = "Headline 7",
                     Content = "Contact 7",
                     PublishedDate = DateTime.UtcNow,
                     ReportedDate = DateTime.UtcNow,
                     UpdatedDate = null,
                     Reporter = new ContactsReporter
                     {
                        ReportedId = 1,
                        FirstName = "fName",
                        LastName = "lName"
                     }
                },
                new Contact
                {
                     ContactsId = Guid.NewGuid(),
                     Category = category1,
                     Title = "Headline 8",
                     Content = "Contact 8",
                     PublishedDate = DateTime.UtcNow,
                     ReportedDate = DateTime.UtcNow,
                     UpdatedDate = null,
                     Reporter = new ContactsReporter
                     {
                        ReportedId = 4,
                        FirstName = "fName",
                        LastName = "lName"
                     }
                },
                new Contact
                {
                     ContactsId = Guid.NewGuid(),
                     Category = category1,
                     Title = "Headline 9",
                     Content = "Contact 9",
                     PublishedDate = DateTime.UtcNow,
                     ReportedDate = DateTime.UtcNow,
                     UpdatedDate = null,
                     Reporter = new ContactsReporter
                     {
                        ReportedId = 5,
                        FirstName = "fName",
                        LastName = "lName"
                     }
                },
                new Contact
                {
                     ContactsId = Guid.NewGuid(),
                     Category = category4,
                     Title = "Headline 10",
                     Content = "Contact 10",
                     PublishedDate = DateTime.UtcNow,
                     ReportedDate = DateTime.UtcNow,
                     UpdatedDate = null,
                     Reporter = new ContactsReporter
                     {
                        ReportedId = 1,
                        FirstName = "fName",
                        LastName = "lName"
                     }
                },
                new Contact
                {
                     ContactsId = Guid.NewGuid(),
                     Category = category5,
                     Title = "Headline 1",
                     Content = "Add 1",
                     PublishedDate = DateTime.UtcNow,
                     ReportedDate = DateTime.UtcNow,
                     UpdatedDate = null,
                     Reporter = new ContactsReporter
                     {
                        ReportedId = 1,
                        FirstName = "fName",
                        LastName = "lName"
                     }
                },
                new Contact
                {
                     ContactsId = Guid.NewGuid(),
                     Category = category5,
                     Title = "Headline 2",
                     Content = "Add 2",
                     PublishedDate = DateTime.UtcNow,
                     ReportedDate = DateTime.UtcNow,
                     UpdatedDate = null,
                     Reporter = new ContactsReporter
                     {
                        ReportedId = 1,
                        FirstName = "fName",
                        LastName = "lName"
                     }
                },
                new Contact
                {
                     ContactsId = Guid.NewGuid(),
                     Category = category5,
                     Title = "Headline 3",
                     Content = "Add 3",
                     PublishedDate = DateTime.UtcNow,
                     ReportedDate = DateTime.UtcNow,
                     UpdatedDate = null,
                     Reporter = new ContactsReporter
                     {
                        ReportedId = 1,
                        FirstName = "fName",
                        LastName = "lName"
                     }
                },
                new Contact
                {
                     ContactsId = Guid.NewGuid(),
                     Category = category5,
                     Title = "Headline 4",
                     Content = "Add 4",
                     PublishedDate = DateTime.UtcNow,
                     ReportedDate = DateTime.UtcNow,
                     UpdatedDate = null,
                     Reporter = new ContactsReporter
                     {
                        ReportedId = 1,
                        FirstName = "fName",
                        LastName = "lName"
                     }
                },
                new Contact
                {
                     ContactsId = Guid.NewGuid(),
                     Category = category5,
                     Title = "Headline 5",
                     Content = "Add 5",
                     PublishedDate = DateTime.UtcNow,
                     ReportedDate = DateTime.UtcNow,
                     UpdatedDate = null,
                     Reporter = new ContactsReporter
                     {
                        ReportedId = 1,
                        FirstName = "fName",
                        LastName = "lName"
                     }
                }
            };*/
            return Contact;
        }

        #endregion
    }
}
