using Microsoft.EntityFrameworkCore;

namespace ConsoleApp13
{
    public class MartekingMysqlContext : DbContext
    {
        public DbSet<Marketing> Marketings { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"Server=localhost;User ID=root;Password=;Database=Marketing; MySqlBulkLoader.Local=true, AllowLoadLocalInfile=true ",
            new MySqlServerVersion(new Version(8, 0, 11)));
        }
    }
}
