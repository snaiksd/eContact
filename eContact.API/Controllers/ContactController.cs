using eContact.Business;
using eContact.Business.Managers;
using eContact.Business.Validation;
using eContact.Data.Entities;
using eContact.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ContactController : Controller
    {
        ContactManager contactManager;
        // GET: Contact
        public IEnumerable<Contact> Index()
        {
            return contactManager.GetContacts();
        }

        // POST: Contact/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                // change with suitable HTTP error and errormessage
                return View();
            }
        }

        // GET: Contact/Edit/5
        public Contact Edit(int id)
        {
            return contactManager.GetContactById(id);
        }

        // POST: Contact/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: Contact/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public int DeleteContact(int id)
        {
            try
            {
                contactManager.DeleteContact(id);
                return 1;
            }
            catch
            {
                // change with suitable HTTP error and errormessage
                return 0;
                //return View();
            }
        }
    }
}
