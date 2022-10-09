using Labb2_Avancerad.Models;
using Labb2Avancerad_V2.Models;
using Microsoft.EntityFrameworkCore;
using Labb2Avancerad_V2.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


//Inject DbContext
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddCors((setup) => setup.AddPolicy("default", (Options =>
{
    Options.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();
})));



 // Inject Repositories
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();










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

app.UseCors("default");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Run();
