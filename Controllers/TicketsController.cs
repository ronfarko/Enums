using Enums.DTOs;
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
        public ActionResult<List<GetTicketDto>> Get()
        {
            return Ok(_service.GetAllTickets());
        }
    }
}
