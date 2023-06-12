using Microsoft.EntityFrameworkCore;
using Estudo_API_NET6.Data;

var builder = WebApplication.CreateBuilder(args);

/* conexão com o banco */
var connectionString = builder.Configuration.GetConnectionString("FilmeConnection");
builder.Services.AddDbContext<FilmeContext>(options => options.UseMySql(
    connectionString,ServerVersion.AutoDetect(connectionString)
));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHsts();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
