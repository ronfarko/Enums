namespace Enums.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        public string? Description { get; set; }

        public string? Issuer { get; set; }

        public TicketStatus Status { get; set; } = TicketStatus.OPEN;
    }
}
