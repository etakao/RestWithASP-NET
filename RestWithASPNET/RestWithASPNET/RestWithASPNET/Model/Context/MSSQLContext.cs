using Microsoft.EntityFrameworkCore;

namespace RestWithASPNET.Model.Context
{
    public class MSSQLContext : DbContext
    {
        public MSSQLContext()
        {
        }

        public MSSQLContext(DbContextOptions<MSSQLContext> options) : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
