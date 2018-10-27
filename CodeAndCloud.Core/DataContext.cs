using CodeAndCloud.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeAndCloud.Core
{
    public class DataContext : DbContext
    {
        public virtual DbSet<ContactModel> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=CodeAndCloud;Trusted_Connection=true;");
            optionsBuilder.UseSqlServer(@"Server = tcp:serverdwanpawdwanida.database.windows.net, 1433; Initial Catalog = mybase; Persist Security Info = False; User ID = PaWeek; Password = K@ktusek1; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

    }
}
