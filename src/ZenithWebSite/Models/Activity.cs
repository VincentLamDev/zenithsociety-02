using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZenithWebSite.Models
{
    public class Activity
    {

        public int ActivityId { get; set; }

        [Required(ErrorMessage = "Must enter a description of the event")]
        [DisplayName("Activity")]
        public string Description { get; set; }

        [DisplayName("Creation Date")]
        public DateTime CreationDate { get; set; }

        public List<Event> Events { get; set; }
    }
}
