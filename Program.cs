var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Serve default files (like index.html) and other static content in wwwroot
app.UseDefaultFiles();
app.UseStaticFiles();

app.Run();
