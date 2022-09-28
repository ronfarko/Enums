using System.ComponentModel;

namespace Enums.Models
{
    public enum TicketStatus
    {
        [Description("Open")]
        OPEN = 1, 
        
        [Description("In Progress")]
        IN_PROG = 2, 
        
        [Description("Complete")]
        DONE = 3
    }
}
