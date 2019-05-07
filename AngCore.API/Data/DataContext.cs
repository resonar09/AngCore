using AngCore.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AngCore.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>  options) : base (options) {}

        public DbSet<Value> Values { get; set; }

        public DbSet<Todo> Todos { get; set; }

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

        bldr.Entity<Todo>()
        .HasData(new Todo
        {
            Id = 1,
            Name = "Clean your room.",
            Description = "Clean your room.",
            Completed = false
        },
        new Todo
        {
            Id = 2,
            Name = "Hang the pictures",
            Description = "Clean your room.",
            Completed = false
        },
        new Todo
        {
            Id = 3,
            Name = "Finish the Todo App",
            Description = "Finish coding the todo app.",
            Completed = false
        });

    }
    }
}