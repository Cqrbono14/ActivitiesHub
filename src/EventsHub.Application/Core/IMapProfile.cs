namespace EventsHub.Application.Core;

public interface IMapProfile<TSource, TDestination>
{
    TDestination Create(TSource source);

    void Apply(TSource source, TDestination destination);
}
