using System;
using System.ComponentModel.DataAnnotations;

namespace Ticketing.Web.Models
{
    public class TicketCreateDTO
    {
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Details is required")]
        public string Details { get; set; }

        [Required(ErrorMessage = "Impacted System is required")]
        
        [Display(Name = "Impacted System")]
        public int? ImpactedSystemId { get; set; }

        [Display(Name ="Due Date")]
        public DateTime? DueDate { get; set; }
    }
}