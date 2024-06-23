using Microsoft.EntityFrameworkCore;
using TodoApis.Models;

namespace TodoApis.Data;

public static class TodoDataSeed
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Todo>().HasData(
            new Todo { Title = "Groceries", Description = "Buy gorceries" , EndDateTime = DateTime.UtcNow.AddDays(5), Id = Guid.NewGuid()},
            new Todo { Title = "Form", Description = "Take a form" , EndDateTime = DateTime.UtcNow.AddDays(2), Id = Guid.NewGuid()}
        );
    }
}
