using CoderSquare.Application.DIContainer;
using CoderSquare.Application.MappingProfiles;
using CoderSquare.DataAccess.DIContainer;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(typeof(ProblemProfile).Assembly);


builder.Services
    .AddDatabase(builder.Configuration)
    .AddServiceApp(builder.Configuration);


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
