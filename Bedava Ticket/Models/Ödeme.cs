using System;
using System.Collections.Generic;

namespace Bedava_Ticket.Models;

public partial class Ödeme
{
    public int Id { get; set; }

    public int CardNumber { get; set; }

    public int ExpirationDate { get; set; }

    public int Cvv { get; set; }

}
