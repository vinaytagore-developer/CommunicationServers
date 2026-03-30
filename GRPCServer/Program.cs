var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

app.MapGet("/", async (ctx) =>
{
    await ctx.Response.WriteAsync("Welcome to GRPCServer");
});

app.Run();

