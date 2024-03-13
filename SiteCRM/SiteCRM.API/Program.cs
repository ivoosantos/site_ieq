using Microsoft.EntityFrameworkCore;
using SiteCRM.API.Extensions;
using SiteCRM.Application.Commands.CreateSobre;
using SiteCRM.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("SiteCRM");
builder.Services.AddDbContext<SiteCRMDbContext>(p => p.UseNpgsql(connectionString));
builder.Services.AddHttpClient();

builder.Services.AddInfrastructure();

builder.Services.AddControllers();

builder.Services.AddMediatR(opt => opt.RegisterServicesFromAssemblyContaining(typeof(CreateSobreCommand)));
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
