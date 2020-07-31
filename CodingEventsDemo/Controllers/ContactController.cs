using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CodingEventsDemo.Data;
using CodingEventsDemo.Migrations;
using CodingEventsDemo.Models;
using CodingEventsDemo.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CodingEventsDemo.Controllers
{
    public class ContactController : Controller

    {

        private EventDbContext context;

        public ContactController(EventDbContext dbContext)
        {
            context = dbContext;
        }

        // /Contact/Index
        public IActionResult Index()
        {
            List<Contact> contacts = context.Contacts.ToList();
            return View(contacts);
        }

        //GET /contact/add -added in class
        [HttpGet]
        public IActionResult Add()
        {
            AddContractViewModel viewModel = new AddContractViewModel();
            return View(viewModel);
        }

        //post /contact/add -added in class
        [HttpPost]
        public IActionResult Add(AddContactViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Contact newContact = new Contact
                {
                    Name = viewModel.FirstName + " " + viewModel.LastName,
                    Email = viewModel.Email,
                    PhoneNumber = viewModel.PhoneNumber,
                    City = viewModel.City

                };
                context.Contacts.Add(newContact);
                context.SaveChanges();
                return Redirect("/contact");
            }

            return View(viewModel);
        }

        //get //contact/view/{id}
        [HttpGet]
        public IActionResult View(int id)
        {
            Contact theContact = context.Contacts.Find(id);

            ContactDetailViewModel viewModel = new ContactDetailViewModel(theContact);

            return View(viewModel);
        }



    }
}
