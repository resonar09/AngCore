using AngCore.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AngCore.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>  options) : base (options) {}

        public DbSet<Value> Values { get; set; }

    protected override void OnModelCreating(ModelBuilder bldr)
    {
      bldr.Entity<Value>()
        .HasData(new Value
        {
            Id = 1,
            Name = "Value 1",
        },
        new Value
        {
            Id = 2,
            Name = "Value 2",
        },
        new Value
        {
            Id = 3,
            Name = "Value 3",
        });


    }
    }
}