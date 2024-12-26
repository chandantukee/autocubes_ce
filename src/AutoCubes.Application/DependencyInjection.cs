using AutoCubes.Shared.Commands;
using AutoCubes.Shared.Queries;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AutoCubes.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {

            AddCommandQueryHandlers(services);
            return services;
        }
        private static void AddCommandQueryHandlers(IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.AddScoped<ICommandDispatcher, CommandDispatcher>();
            services.AddScoped<IQueryDispatcher, QueryDispatcher>();
            // Register all ICommandHandler<> implementations
            services.Scan(scan => scan
                .FromAssemblies(assembly)
                .AddClasses(classes => classes.AssignableTo(typeof(ICommandHandler<>)))
                .AsImplementedInterfaces()
                .WithScopedLifetime());

            // Register all IQueryHandler<,> implementations
            services.Scan(scan => scan
                .FromAssemblies(assembly)
                .AddClasses(classes => classes.AssignableTo(typeof(IQueryHandler<,>)))
                .AsImplementedInterfaces()
                .WithScopedLifetime());
        }
    }
}
