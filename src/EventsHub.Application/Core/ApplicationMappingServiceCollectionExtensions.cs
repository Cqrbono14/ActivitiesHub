using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace EventsHub.Application.Core;

public static class ApplicationMappingServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationMapper(this IServiceCollection services, params Assembly[] assemblies)
    {
        ArgumentNullException.ThrowIfNull(services);
        ArgumentNullException.ThrowIfNull(assemblies);

        if (assemblies.Length == 0)
        {
            assemblies = [typeof(ApplicationMappingServiceCollectionExtensions).Assembly];
        }

        var profiles = assemblies
            .SelectMany(assembly => assembly.GetTypes())
            .Where(type => type.IsClass && !type.IsAbstract && !type.ContainsGenericParameters)
            .SelectMany(type => type.GetInterfaces()
                .Where(@interface => @interface.IsGenericType
                    && @interface.GetGenericTypeDefinition() == typeof(IMapProfile<,>))
                .Select(@interface => (Service: @interface, Implementation: type)))
            .ToArray();

        var registry = services
            .FirstOrDefault(descriptor => descriptor.ServiceType == typeof(MappingRegistry))?
            .ImplementationInstance as MappingRegistry ?? new MappingRegistry();

        var seen = new HashSet<(Type Source, Type Destination)>();
        foreach (var (service, _) in profiles)
        {
            var arguments = service.GetGenericArguments();
            var pair = (Source: arguments[0], Destination: arguments[1]);
            if (!seen.Add(pair) || registry.Contains(pair.Source, pair.Destination)
                || services.Any(descriptor => descriptor.ServiceType == service))
            {
                throw new InvalidOperationException(
                    $"Duplicate mapping profile for {pair.Source.FullName} -> {pair.Destination.FullName}.");
            }
        }

        if (!services.Any(descriptor => descriptor.ServiceType == typeof(MappingRegistry)))
        {
            services.AddSingleton(registry);
            services.AddSingleton<IApplicationMapper, ApplicationMapper>();
        }

        foreach (var (service, implementation) in profiles)
        {
            var arguments = service.GetGenericArguments();
            registry.Add(arguments[0], arguments[1]);
            services.AddSingleton(service, implementation);
        }

        return services;
    }
}
