using System.Collections.Generic;
using System.Web.Mvc;

namespace Ticketing.Web.Models
{
    public class TicketCreateViewModel : TicketCreateDTO
    {
        public List<SelectListItem> ImpactedSystems { get; set; }
    }
}