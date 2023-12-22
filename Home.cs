using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();
    
        app.MapGet("/", async context =>
        {
            await context.Response.WriteAsync("Successfully Deployed DotNet app in Azure WebApp");
        });
    
        app.Run();
    }
}
