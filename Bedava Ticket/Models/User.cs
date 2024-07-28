using System;
using System.Collections.Generic;

namespace Bedava_Ticket.Models;

public partial class User
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public string Passoword { get; set; } = null!;

}
