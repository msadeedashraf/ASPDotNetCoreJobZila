using Microsoft.EntityFrameworkCore;

namespace JobZila.Data
{
    public class ApplicationDBContext :DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options ) : base( options ) { }

        public DbSet<Jobs> jobs { get; set; }   





    }
}
