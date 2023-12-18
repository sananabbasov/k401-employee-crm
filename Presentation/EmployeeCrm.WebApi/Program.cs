using EmployeeCrm.Persistence;
using EmployeeCrm.Application.DependencyResolver;
using Microsoft.AspNetCore.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddPersistenceServices();
builder.Services.AddApplicationServices();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// Exception-lari json kimi geriye qaytarir.
//app.UseExceptionHandler(c => c.Run(async context =>
//{
//    var exception = context.Features
//        .Get<IExceptionHandlerPathFeature>()
//        .Error;
//    var response = new { error = exception.Message };
//    await context.Response.WriteAsJsonAsync(response);
//}));

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

