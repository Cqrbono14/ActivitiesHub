namespace EventsHub.Application.Core;

internal sealed class MappingRegistry
{
    private readonly HashSet<(Type Source, Type Destination)> pairs = [];

    public bool Contains(Type source, Type destination) => pairs.Contains((source, destination));

    public void Add(Type source, Type destination) => pairs.Add((source, destination));
}
