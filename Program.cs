var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World - TechStore (.NET 8 LTS)");

app.Run();
