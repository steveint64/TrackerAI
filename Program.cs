var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Serve wwwroot files (like /index.html)
app.UseDefaultFiles();  // Looks for index.html
app.UseStaticFiles();   // Serves it

app.Run();
