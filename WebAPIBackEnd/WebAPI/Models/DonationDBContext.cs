using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models
{
    /*
     * 
     * Add-Migration "Init"
    Run at Package Manager Console
    Update-Database
     */

    public class DonationDBContext : DbContext
    {
        public DonationDBContext(DbContextOptions<DonationDBContext> options) : base(options)
        {
        }

        public DbSet<DCandidate> DCandidates { get; set; }
    }
}