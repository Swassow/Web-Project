using logindemo.Models;
using Microsoft.EntityFrameworkCore;

namespace logindemo.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<travelData> travelDatas { get; set; }
    }
}
