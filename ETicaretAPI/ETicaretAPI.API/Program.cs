using ETicaretAPI.Persistence;
using ETicaretAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var Configuration = builder.Configuration;
builder.Services.AddDbContext<ETicaretAPIDbContext>(options =>
    options.UseNpgsql(Configuration.GetConnectionString("PostgreSQL")));

var configuration = builder.Configuration;

builder.Services.AddPersistenceServices(configuration);

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