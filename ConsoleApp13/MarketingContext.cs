using Microsoft.EntityFrameworkCore;

namespace ConsoleApp13
{
    public class MarketingContext : DbContext
    {
        public DbSet<Marketing> Marketings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-607521A;Database=BulkTeste;Trusted_Connection=True;");
        }
    }
}
