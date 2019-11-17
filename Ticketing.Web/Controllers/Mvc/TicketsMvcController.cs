using System.Collections.Generic;
using System.Web.Mvc;
using Ticketing.Web.Models;

namespace Ticketing.Web.Controllers.Mvc
{
    public class TicketsMvcController : Controller
    {
        // GET: Tickets/Create
        public ActionResult Create()
        {
            var viewModel = new TicketCreateViewModel();
            viewModel.ImpactedSystems = new List<SelectListItem>
            {
                new SelectListItem { Value = "1", Text = "Accounting" },
                new SelectListItem { Value = "2", Text = "Booking" },
                new SelectListItem { Value = "3", Text = "Sales" }
            };
            return View(viewModel);
        }
    }
}