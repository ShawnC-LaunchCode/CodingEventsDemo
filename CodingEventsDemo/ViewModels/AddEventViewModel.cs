using System;
using System.ComponentModel.DataAnnotations;

namespace CodingEventsDemo.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage ="Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage ="Name has to be between 3 and 50 chars")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please enter a desc.")]
        [StringLength(500, ErrorMessage ="Desc too long")]
        public string Description { get; set; }


        [EmailAddress]
        public string ContactEmail { get; set; }
    }
}
