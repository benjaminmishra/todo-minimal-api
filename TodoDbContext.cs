using Microsoft.EntityFrameworkCore;
using TodoApis.Models;

namespace TodoApis.Data;

public class TodoDbContext : DbContext
{
    public DbSet<Todo> Todos { get; set; }

    public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        new TodoEntityConfigurations().Configure(modelBuilder.Entity<Todo>());
        modelBuilder.Seed();
    }
}
