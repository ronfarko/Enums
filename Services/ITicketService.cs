using Enums.DTOs;

namespace Enums.Services
{
    public interface ITicketService
    {
        List<GetTicketDto> GetAllTickets();
    }
}
