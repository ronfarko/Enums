using AutoMapper;
using Enums.DTOs;
using Enums.Models;

namespace Enums.Services
{
    public class TicketService : ITicketService
    {
        private readonly IMapper _mapper;

        public TicketService(IMapper mapper)
        {
            _mapper = mapper;
        }

        private readonly List<Ticket>? _ticketList = new List<Ticket>  {
            new Ticket() {
                Id = 1, 
                Description = "First Ticket", 
                Issuer = "John", 
                Status = TicketStatus.OPEN 
            },
            new Ticket() {
                Id = 2, 
                Description = "Second Ticket", 
                Issuer = "Joe", 
                Status = TicketStatus.IN_PROG 
            }
        };

        public List<GetTicketDto>? GetAllTickets()
        {
            return _mapper.Map<List<GetTicketDto>>(_ticketList);
        }
    }
}
