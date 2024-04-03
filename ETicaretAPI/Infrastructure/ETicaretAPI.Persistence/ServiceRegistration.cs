using Microsoft.EntityFrameworkCore;
using ETicaretAPI.Persistence.Contexts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaretAPI.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ETicaretAPIDbContext>(options => options.UseNpgsql("Host=localhost; Port=5432; User Id=postgres; Password=1234; Database=ETicaretAPIDb"));
    }
}

// public static class ServiceRegistration
// {
//     public static void AddPersistenceServices(this IServiceCollection services)
//     {
//         services.AddDbContext<ETicaretAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
//     }
// }