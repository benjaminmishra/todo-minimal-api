using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApis.Data;
using TodoApis.Models;

namespace TodoApis.Endpoints;

public static class TaskEndpoints
{
    public static void RegisterTodoEndPoints(this RouteGroupBuilder routeGroupBuilder)
    {
        var todoGroupBuilder = routeGroupBuilder.MapGroup("/todo");

        todoGroupBuilder.MapGet("/", GetTodos)
        .Produces<IEnumerable<Todo>>(200);

        todoGroupBuilder.MapGet("/{Id:guid}",GetTodo);
    }

    public static async Task<IEnumerable<Todo>> GetTodos(TodoDbContext dbContext)
    {
        return await dbContext.Todos.ToListAsync();
    }

    public static async Task<Todo?> GetTodo(TodoDbContext dbContext, [FromRoute]Guid Id)
    {
        return await dbContext.Todos.FirstOrDefaultAsync(x=>x.Id==Id);
    }
}