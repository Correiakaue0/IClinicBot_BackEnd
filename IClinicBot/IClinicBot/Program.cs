using IClinicBot.Domain.Interfaces.Repository;
using IClinicBot.Domain.Interfaces.Service;
using IClinicBot.Infrastructure.Repository;
using IClinicBot.Service.Services;
using Infrastructure.Context;

var builder = WebApplication.CreateBuilder(args);

// Injection Of Controll
// Service
builder.Services.AddScoped<IDoctorService, DoctorService>();

// Repository
builder.Services.AddScoped<IDoctorRepository, DoctorRepository>();

// SqlContext
builder.Services.AddScoped<Context, Context>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configuration Cors
app.UseCors("corsapp");
app.UseCors(c =>
{
    c.AllowAnyHeader();
    c.AllowAnyMethod();
    c.AllowAnyOrigin();
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
