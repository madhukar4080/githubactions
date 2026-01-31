var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "Hello World from Azure Web App deployed using GitHub Actions 🚀");

app.MapGet("/health", () => Results.Ok("Healthy"));

app.Run();
