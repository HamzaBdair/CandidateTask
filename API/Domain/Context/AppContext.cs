using API.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Domain.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Candidate> Candidates { get; set; }
    }
}
