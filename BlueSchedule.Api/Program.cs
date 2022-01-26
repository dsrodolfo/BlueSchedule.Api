using BlueSchedule.Application.Installers;
using BlueSchedule.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetSection("DbContextSettings")["ConnectionString"];
builder.Services.AddDbContext<BlueScheduleDbContext>(options => options.UseNpgsql(connectionString));

builder.Services.AddMediatRServices()
                .AddRepositoryServices()
                .AddAutoMapperServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();