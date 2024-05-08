using Microsoft.EntityFrameworkCore;
using Session3.Models;

namespace Session3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=db4774.databaseasp.net; Database=db4774; User Id=db4774; Password=c-6W@7JoP_p2; Encrypt=False; MultipleActiveResultSets=True;");
        }
    }
}
