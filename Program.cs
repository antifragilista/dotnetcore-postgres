using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// builder.Services.AddDbContext<TodoDb>(opt =>
//     opt.UseNpgsql(builder.Configuration.GetConnectionString("TodoDatabase")));

var connectionString = builder.Configuration.GetConnectionString("TodoDb");
builder.Services.AddDbContext<TodoDb>(opt 
    => opt.UseNpgsql(connectionString));

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();