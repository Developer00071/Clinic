using Application.Interfaces;
using Application.Services;
using Domain.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<AppDbConection>();

builder.Services.AddScoped<IDoctorsRepository, DoctorsRepository>();
builder.Services.AddScoped<IDoctorsService, DoctorsService>();

builder.Services.AddScoped<IPatientsRepository, PatientsRepository>();
builder.Services.AddScoped<IPatientsService, PatientsService>();

builder.Services.AddScoped<IRoomsRepository, RoomsRepository>();
builder.Services.AddScoped<IRoomsService, RoomsService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.Run();
