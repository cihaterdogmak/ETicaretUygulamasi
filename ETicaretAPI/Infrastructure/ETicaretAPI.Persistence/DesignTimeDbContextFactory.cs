using System.Diagnostics;
using ETicaretAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ETicaretAPI.Persistence;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ETicaretAPIDbContext>
{
    public DesignTimeDbContextFactory()
    { 
        // Bu constructor'ı Entity Framework Core araçları kullanacak.
    }
    
    private readonly IConfiguration _configuration;

    public DesignTimeDbContextFactory(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public ETicaretAPIDbContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<ETicaretAPIDbContext> dbContextOptionsBuilder = new();
        // dbContextOptionsBuilder.UseNpgsql(_configuration.GetConnectionString("PostgreSQL"));
        dbContextOptionsBuilder.UseNpgsql("Host=localhost; Port=5432; User Id=postgres; Password=1234; Database=ETicaretAPIDb");
        return new(dbContextOptionsBuilder.Options);
    }
}
