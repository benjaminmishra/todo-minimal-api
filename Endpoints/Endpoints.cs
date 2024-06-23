namespace TodoApis.Endpoints;

public static class Endpoints
{
    public static void RegsterEndpoints(this IEndpointRouteBuilder routeBuilder)
    {
        var routeGroupBuilder = routeBuilder.MapGroup("/api");

        routeGroupBuilder.RegisterTodoEndPoints();
    }
}
