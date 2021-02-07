using eContact.API.Controllers;
using eContact.Services;
using eContact.Data.Entities;
using System.Collections.Generic;
using System.Linq;
using Moq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Web.Http.Results;
using System;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;

namespace eContact.Tests.Controllers
{
    [TestFixture]
    public class ContactControllerTest
    {
        Random rnd = new Random();
        private Mock<IContactService> _mockContactService;
        ContactController controller;
        public ContactControllerTest()
        {
            _mockContactService = new Mock<IContactService>();
            controller = new ContactController(_mockContactService.Object);
            var contacts = GetContact();
            var contact = GetFirstContact();
            _mockContactService.Setup(m => m.GetContact()).Returns((contacts));

        }


        [TestCase]
        public void Get_Success()
        {
            // Act
            Task<ActionResult> result = controller.Index();

            // Assert
            Assert.IsNotNull(result.Result);
            IActionResult aclst = result.Result as IActionResult;
            OkObjectResult lst = aclst as OkObjectResult;
            List<Contact> lstContact = lst.Value as List<Contact>;

            Assert.AreEqual(2, lstContact.Count); // Total 10 records avail
        }

        [TestCase]
        public void Post()
        {
            Contact cnt = GetFirstContact();
            _mockContactService.Setup(m => m.AddContact(cnt));
            // Act
            controller.Create(cnt);

            // Assert
        }

        [TestCase]
        public void Update()
        {
            Contact cnt = GetFirstContact();
            _mockContactService.Setup(m => m.UpdateContact(cnt)).Returns(1);
            // Act
            OkObjectResult result = controller.Edit(cnt) as OkObjectResult;

            Assert.AreEqual(1, result.Value);
            // Assert
        }

        [TestCase]
        public void Delete()
        {
            _mockContactService.Setup(m => m.DeleteContact(1));
            // Act
            controller.DeleteContact(1);

            // Assert
        }

        private Contact GetFirstContact()
        {
            return GetContact().Result.First();
        }


        private Task<List<Contact>> GetContact()
        {
            List<Contact> conts = new List<Contact>() {
                new Contact
                {
                     ContactId = rnd.Next(),
                     FirstName ="Hritik",
                     LastName ="Roshan",
                     Email="hritik@test.com",
                     PhoneNumber="9999999999",
                     Status=true
                },
                new Contact
                {
                     ContactId = rnd.Next(),
                     FirstName ="Amitabh",
                     LastName ="Bachhan",
                     Email="amitabh@test.com",
                     PhoneNumber="9999999999",
                     Status=true
                }
            };

            return Task.Run(() => conts);
        }
    }
}
