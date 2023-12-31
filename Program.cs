using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using TravelLove;
using TravelLove.Models;
using TravelLove.Repository.RegisterUsersRepository;

var builder = WebApplication.CreateBuilder(args);

// Configure CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularOrigins", builder =>
    {
        builder.WithOrigins("http://localhost:4200")
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});

// Add services to the container.
builder.Services.AddDbContext<TravelLoveDbContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("DbCon")));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IRegisterUsersRepository, RegisterUsersRepository>();

// Configure Serilog logger
Log.Logger = new LoggerConfiguration().WriteTo.File("D:\\sairamvir\\mylog.log", rollingInterval: RollingInterval.Day).CreateLogger();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Apply CORS middleware
app.UseCors("AllowAngularOrigins");

app.UseAuthorization();
app.MapControllers();

app.Run();

