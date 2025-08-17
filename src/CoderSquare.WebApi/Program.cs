using AutoMapper;
using CoderSquare.Application.DIContainer;
using CoderSquare.Application.MappingProfiles;
using CoderSquare.DataAccess.DIContainer;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);



builder.Services
    .AddDatabase(builder.Configuration)
    .AddServiceApp(builder.Configuration);


// Mapper 
//builder.Services.AddAutoMapper(ProblemProfile);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

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
