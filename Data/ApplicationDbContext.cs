using Microsoft.EntityFrameworkCore;
using aspcoreauth.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace aspcoreauth.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Models.SalesLeadEntity> SalesLead { get; set; }
    }
}
