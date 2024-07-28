using System;
using System.Collections.Generic;

namespace Bedava_Ticket.Models;

public partial class Yolcu
{
    public int Id { get; set; }

    public int? KimlikNo { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateOnly? Date { get; set; }

    public string? Gender { get; set; }

    public string? Email { get; set; }

    public int? Phone { get; set; }
}
