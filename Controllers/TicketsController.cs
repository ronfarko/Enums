using Enums.Models;
using Enums.Services;
using Microsoft.AspNetCore.Mvc;

namespace Enums.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TicketsController : ControllerBase
    {
        private readonly ITicketService _service;

        public TicketsController(ITicketService service)
        {
            _service=service;
        }

        [HttpGet]
        public ActionResult<Ticket> Get()
        {
            return Ok(_service.GetAllTickets());
        }
    }
}
