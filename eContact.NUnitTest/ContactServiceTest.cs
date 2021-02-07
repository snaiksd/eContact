using eContact.Data.Entities;
using eContact.Data.SqlServer.Repository;
using eContact.Services;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eContact.Tests.Services
{
    [TestFixture]
    public class ContactServiceTest
    {
        private IContactService _contactService;
        private Mock<IBaseRepository<Contact>> _mockContext;

        public ContactServiceTest()
        {
            _mockContext = new Mock<IBaseRepository<Contact>>();
            _contactService = new ContactService(_mockContext.Object);
        }

        [TestCase]
        public void GetMockNews_NotEmpty()
        {
            // Arrange
            Task<List<Contact>> contacts = GetContact();
            _mockContext.Setup(m => m.GetAllAsync()).Returns((contacts));

            // Act
            var result = _contactService.GetContact();

            // Assert
            Assert.IsNotNull(result.Result);
            Assert.AreEqual(1, result.Result.Count()); // Total 10 records avail
        }

        #region Private 

        private Task<List<Contact>> GetContact()
        {
            Random rnd = new Random();
            List<Contact> conts = new List<Contact>() {
                new Contact
                {
                     ContactId = rnd.Next(),
                     FirstName ="Santosh",
                     LastName ="Nayak",
                     Email="santosh@test.com",
                     PhoneNumber="9999999999",
                     Status=true
                }                
            };

            return Task.Run(() => conts);
        }

        #endregion
    }
}
