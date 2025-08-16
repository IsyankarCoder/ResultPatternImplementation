var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddScoped<IUserService, UserService>();


var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapControllers();
app.Run();
