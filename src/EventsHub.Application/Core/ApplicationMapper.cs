using Microsoft.Extensions.DependencyInjection;

namespace EventsHub.Application.Core;

internal sealed class ApplicationMapper(IServiceProvider services, MappingRegistry registry) : IApplicationMapper
{
    public TDestination Map<TSource, TDestination>(TSource source)
    {
        ArgumentNullException.ThrowIfNull(source);

        EnsureRegistered<TSource, TDestination>();
        return services.GetRequiredService<IMapProfile<TSource, TDestination>>().Create(source);
    }

    public void Map<TSource, TDestination>(TSource source, TDestination destination)
    {
        ArgumentNullException.ThrowIfNull(source);
        ArgumentNullException.ThrowIfNull(destination);

        EnsureRegistered<TSource, TDestination>();
        services.GetRequiredService<IMapProfile<TSource, TDestination>>().Apply(source, destination);
    }

    private void EnsureRegistered<TSource, TDestination>()
    {
        if (!registry.Contains(typeof(TSource), typeof(TDestination)))
        {
            throw new InvalidOperationException(
                $"No mapping profile is registered for {typeof(TSource).FullName} -> {typeof(TDestination).FullName}.");
        }
    }
}
