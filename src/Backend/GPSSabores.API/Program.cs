using GPSSabores.API.Infrastructure;
using GPSSabores.API.Middleware;
using GPSSabores.Application;
using GPSSabores.Infrastructure;


var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddMvc(options => options.Filters.Add(typeof(ExceptionFilter)));


builder.Services.AddApplication(builder.Configuration);
builder.Services.AddInfrastruture(builder.Configuration);

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseMiddleware<CultureMilddleware>();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
