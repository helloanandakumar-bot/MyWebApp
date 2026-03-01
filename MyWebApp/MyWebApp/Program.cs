var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapGet("/", () => Results.Redirect("/index.html"));
app.MapGet("/api/hello", () => new { message = "Hello from .NET on Windows!", time = DateTime.Now });

app.Run();