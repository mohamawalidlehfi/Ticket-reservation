using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;

namespace Bedava_Ticket.Models;

public partial class Müşteri
{
    public int Id { get; set; }
    [Required]
    public string? Gidiş { get; set; }
    [Required]
    public string? Dönüş { get; set; }
    [Required]
    public DateOnly? GidişZaman { get; set; }
    [Required]
    public DateOnly? DönüşZaman { get; set; }
    [Required]
    public int? Babaklar { get; set; }
    [Required]
    public int? Yetişkinler { get; set; }
    [Required]
    public int? Çocuklar { get; set; }
    [Required]
    public int Totol { get; set; }

}
