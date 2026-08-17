var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// Простая страница по корню, чтобы при заходе в браузере не получать 404
app.MapGet("/", () => Results.Text("LifeFlow API работает"));

app.Run();
