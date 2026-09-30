# Application mapping

Mappings use `IMapProfile<TSource, TDestination>` in `EventsHub.Application.Core`. A profile lists every assignment. It creates a new destination with `Create` and updates an existing destination with `Apply`.

The unit test assembly contains this example profile:

```csharp
public sealed class SampleProfile : IMapProfile<SampleSource, SampleDestination>
{
    public SampleDestination Create(SampleSource source)
    {
        var destination = new SampleDestination();
        Apply(source, destination);
        return destination;
    }

    public void Apply(SampleSource source, SampleDestination destination)
    {
        destination.Value = $"Mapped: {source.Text}";
        destination.Length = source.Text.Length;
    }
}
```

Put each concrete profile in an assembly passed to `AddApplicationMapper`. The API currently uses the Application assembly by default:

```csharp
builder.Services.AddApplicationMapper();
```

For profiles in another module, include its assembly:

```csharp
builder.Services.AddApplicationMapper(
    typeof(EventToEventProfile).Assembly,
    typeof(SampleProfile).Assembly);
```

The test `DiscoversAdditionalAssemblyWithoutChangingMapper` registers these two assemblies and resolves `SampleProfile` through `IApplicationMapper`. The mapper can create or update a destination:

```csharp
var created = mapper.Map<SampleSource, SampleDestination>(source);
mapper.Map(source, existingDestination);
```

`Apply` must mutate the supplied destination. Registration fails for duplicate source/destination pairs. A mapping request for an unregistered pair throws an error naming both types. Null source and destination arguments are rejected.
