using System;
using System.Collections.Generic;

namespace Bedava_Ticket.Models;

public partial class Contact
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Subject { get; set; }

    public string? Massage { get; set; }
}
