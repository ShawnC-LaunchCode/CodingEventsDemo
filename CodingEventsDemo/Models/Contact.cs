using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEventsDemo.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }

        public Contact()
        {

        }

        public Contact(string name, string email, string phone, string city)
        {
            this.Name = name;
            this.Email = email;
            this.PhoneNumber = phone;
            this.City = city;
        }
    }
}
