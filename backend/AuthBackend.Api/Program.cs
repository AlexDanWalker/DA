using AuthBackend.Application.Services;
using AuthBackend.Domain.Repositories;
using AuthBackend.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();          // Para los controllers
builder.Services.AddEndpointsApiExplorer(); // Swagger
builder.Services.AddSwaggerGen();

// Inyección de dependencias DDD
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<AuthService>();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();  // en caso de agregar auth más adelante

app.MapControllers(); // Mapea todos los controllers

app.Run();