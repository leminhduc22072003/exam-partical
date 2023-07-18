using System;
using exam_partical.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exam_partical.Entities;
using exam_partical.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace exam_partical.Controllers
{
    public class ContactController : Controller
    {

        private readonly DataContact _contact;
        public ContactController(DataContact dataContact)
        {
            _contact = dataContact;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Contact> contacts = _contact.Contacts.ToList<Contact>();
            return View(contacts);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ContactViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _contact.Contacts.Add(new Contact { ContactName = viewModel.ContactName });
                _contact.Contacts.Add(new Contact { ContactNumber = viewModel.ContactNumber });
                _contact.Contacts.Add(new Contact { GroupName = viewModel.GroupName });
                _contact.Contacts.Add(new Contact { HireDate = viewModel.HireDate });
                _contact.Contacts.Add(new Contact { Birthday = viewModel.Birthday });
                _contact.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(viewModel);
        }
    }
}