using System;
using System.Collections.Generic;

namespace Bedava_Ticket.Models;

public partial class Fatura
{
    public int Id { get; set; } 

    public string? Type { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int? KimlikNo { get; set; }
}
