using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Bedava_Ticket.Models;

namespace Bedava_Ticket.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Bedava_Ticket.Models.Müşteri> Müşteri { get; set; } = default!;
    }
}
