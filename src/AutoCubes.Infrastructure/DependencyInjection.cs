using AutoCubes.Application.Contracts.Masters;
using AutoCubes.Infrastructure.CommandRepository;
using AutoCubes.Infrastructure.Context;
using AutoCubes.Infrastructure.QueryRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MySqlConnector;
using System.Data;

namespace AutoCubes.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,IConfiguration configuration)
        {
            AddDbContext(services, configuration);
            services.AddTransient<IDbConnection>(sp => new MySqlConnection(configuration.GetConnectionString("AutoCubesDbConnection")));
            services.AddScoped<ICountriesCommandRepository, CountryCommandRepository>();
            services.AddScoped<ICountriesQueryRepository, CountriesQueryRepository>();
            services.AddScoped<IOrganizationCommandRepository, OrganizationCommandRepository>();
            services.AddScoped<IOrganizationQueryRepository, OrganizationQueryRepository>();

            return services;
        }

        private static void AddDbContext(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AutoCubesDbContext>(options => options.UseMySql(configuration.GetConnectionString("AutoCubesDbConnection"), ServerVersion.Parse("8.0.30-mysql")));
        }
    }
}
