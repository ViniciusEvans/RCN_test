using Microsoft.EntityFrameworkCore;
using test_2.Models;

namespace test_2.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Person> People { get; set; }
        public DbSet<Pet> Pets { get; set; }

    }
}
