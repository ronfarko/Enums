using Enums.Models;

namespace Enums.DTOs
{
    public class GetTicketDto
    {
        public int Id { get; set; }

        public string? Description { get; set; }

        public string? Issuer { get; set; }

        public string? StatusDisplay { get; set; }
    }
}
