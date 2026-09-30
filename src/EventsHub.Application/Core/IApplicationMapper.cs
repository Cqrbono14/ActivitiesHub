namespace EventsHub.Application.Core;

public interface IApplicationMapper
{
    TDestination Map<TSource, TDestination>(TSource source);

    void Map<TSource, TDestination>(TSource source, TDestination destination);
}
