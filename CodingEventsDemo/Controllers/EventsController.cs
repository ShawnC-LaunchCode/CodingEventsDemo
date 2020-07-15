using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingEventsDemo.Data;
using CodingEventsDemo.Models;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace coding_events_practice.Controllers
{
    public class EventsController : Controller
    {


        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.events = EventData.GetAll();
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("Events/Add")]
        public IActionResult NewEvent(Event newEvent)
        {
            EventData.Add(newEvent);
            

            return Redirect("/Events");
        }


        public IActionResult Delete()
        {
            ViewBag.events = EventData.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int[] eventIds)
        {
            foreach(int i in eventIds)
            {
                EventData.Remove(i);
            }
            
            
            return Redirect("/Events");
        }

        [HttpGet]
        [Route("Events/edit")]
        public IActionResult Edit(int eventId)
        {

            ViewBag.events = EventData.GetAll();

            return View();
        }

        [HttpPost]
        [Route("Events/Edit")]
        public IActionResult SubmitEditEventForm(int eventId, string name, string description)
        {
            ViewBag.events = EventData.GetAll();

            EventData.Edit(eventId, name, description);


            return Redirect("/Events");
        }

    }
}
