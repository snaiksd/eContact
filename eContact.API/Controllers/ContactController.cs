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


namespace eContact.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : Controller
    {
        IContactManager _contactManager;

        public ContactController(IContactManager _contactManager)
        {
            this._contactManager = _contactManager;
        }

        // GET: Contact
        [HttpGet]
        public async Task<ActionResult> Index()
        {
           return Ok(await _contactManager.GetContacts());
        }

        [HttpGet("/{id}")]
        // GET: Contact/Edit/5
        public async Task<ActionResult> GetContact(int id)
        {
            return Ok(await _contactManager.GetContactById(id));
        }

        // POST: Contact/Create
        [HttpPost("/Add")]
        public IActionResult Create(Contact contact)
        {
            try
            {
                _contactManager.AddContact(contact);
                return Ok();
            }
            catch(Exception ex)
            {
                //_logger.LogError(ex.Message);
                return BadRequest(Util.ErrorResponse.FormatResponse("Something went wrong!", ex.Message));
            }
        }

        // POST: Contact/Edit/5
        [HttpPost("/Edit")]
        public IActionResult Edit(Contact contact)
        {
            try
            {
                return Ok(_contactManager.EditContact(contact));
            }
            catch (Exception ex)
            {
                return BadRequest(Util.ErrorResponse.FormatResponse("Something went wrong!", ex.Message));
            }
        }

        // Delete: Contact/Delete/5
        [HttpDelete("/{id}")]
        public IActionResult DeleteContact(int id)
        {
            try
            {
                _contactManager.DeleteContact(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(Util.ErrorResponse.FormatResponse("Something went wrong!", ex.Message));
            }
        }
    }
}
//Design-Santosh Naik