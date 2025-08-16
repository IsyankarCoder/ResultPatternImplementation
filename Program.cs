using Swashbuckle.AspNetCore;
using Swashbuckle.AspNetCore.Swagger;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserService, UserService>();


var app = builder.Build();


app.MapGet("/", () => "Hello World!");
app.MapControllers();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
    
    
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}


app.Run();
