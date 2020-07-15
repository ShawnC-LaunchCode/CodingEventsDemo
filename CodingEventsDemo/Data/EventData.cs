using CodingEventsDemo.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEventsDemo.Data
{
    public class EventData
    {

        //store events
        private static Dictionary<int, Event> Events = new Dictionary<int, Event>();

        //add events
        public static void Add(Event newEvent)
        {
            Events.Add(newEvent.Id, newEvent);
        }

        //retrieve event
        public static IEnumerable<Event> GetAll()
        {
            return Events.Values;
        }

        //retrieve a single event

        public static Event GetById(int Id)
        {
            return Events[Id];
        }

        //remove an event

        public static void Remove(int Id)
        {
            Events.Remove(Id);
        }

        public static void Edit(int id, string name, string desc)
        {
            Events.Remove(id);
            Events.Add(id, new Event(name, desc));
        }

    }
}
