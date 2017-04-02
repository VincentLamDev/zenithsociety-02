using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZenithWebSite.Models
{
    public class Event
    {
        public int EventId { get; set; }

        [Required(ErrorMessage = "Must enter a start time and date")]
        [Display(Name = "Start Date")]
        public DateTime Start { get; set; }

        [Required(ErrorMessage = "Must enter an end time and date")]
        [DisplayName("End Date")]
        public DateTime End { get; set; }

        [DisplayName("Username")]
        public string CreatedBy { get; set; }

        public int ActivityId { get; set; }

        public virtual Activity Activity { get; set; }

        [DisplayName("Creation Date")]
        public DateTime CreationDate { get; set; }

        [DisplayName("Active")]
        public bool IsActive { get; set; }
    }
}
