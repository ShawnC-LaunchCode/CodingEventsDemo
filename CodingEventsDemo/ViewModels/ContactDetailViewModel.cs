using CodingEventsDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEventsDemo.ViewModels
{
    
    public class ContactDetailViewModel
    {
        public string Name { get; set; }

        public ContactDetailViewModel(Contact c)
        {
            Name = c.Name;
        }
    }
}
