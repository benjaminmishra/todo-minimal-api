namespace TodoApis.Endpoints;

public static class Endpoints
{
    public static void RegsterEndpoints(this IEndpointRouteBuilder routeBuilder)
    {
        routeBuilder
        .MapGroup("/api")
        .RegisterTodoEndPoints();
    }
}
