using Microsoft.Extensions.Configuration;
using System.Diagnostics.CodeAnalysis;

namespace ETicaretAPI.Persistence
{
    public class Configuration
    {
        private readonly IConfiguration _configuration;

        public Configuration(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string PostgreSQLConnectionString => _configuration.GetConnectionString("PostgreSQL");
    }
}
