using EventsHub.Application.Core;
using Microsoft.Extensions.DependencyInjection;

namespace EventsHub.UnitTests.Mapping;

[TestFixture]
public class ApplicationMapperTests
{
    [Test]
    public void CreatesAndUpdatesUsingExplicitProfile()
    {
        using var provider = new ServiceCollection()
            .AddApplicationMapper(typeof(SampleProfile).Assembly)
            .BuildServiceProvider();
        var mapper = provider.GetRequiredService<IApplicationMapper>();
        var source = new SampleSource { Text = "EventsHub" };

        var created = mapper.Map<SampleSource, SampleDestination>(source);
        var existing = new SampleDestination { Value = "before" };
        mapper.Map(source, existing);

        Assert.Multiple(() =>
        {
            Assert.That(created.Value, Is.EqualTo("Mapped: EventsHub"));
            Assert.That(created.Length, Is.EqualTo(9));
            Assert.That(existing.Value, Is.EqualTo("Mapped: EventsHub"));
            Assert.That(existing.Length, Is.EqualTo(9));
        });
    }

    [Test]
    public void RejectsNullArguments()
    {
        using var provider = new ServiceCollection()
            .AddApplicationMapper(typeof(SampleProfile).Assembly)
            .BuildServiceProvider();
        var mapper = provider.GetRequiredService<IApplicationMapper>();

        Assert.Multiple(() =>
        {
            Assert.Throws<ArgumentNullException>(() =>
                mapper.Map<SampleSource, SampleDestination>(null!));
            Assert.Throws<ArgumentNullException>(() =>
                mapper.Map<SampleSource, SampleDestination>(null!, new SampleDestination()));
            Assert.Throws<ArgumentNullException>(() =>
                mapper.Map<SampleSource, SampleDestination>(new SampleSource { Text = "x" }, null!));
        });
    }

    [Test]
    public void MissingPairNamesBothTypes()
    {
        using var provider = new ServiceCollection()
            .AddApplicationMapper(typeof(SampleProfile).Assembly)
            .BuildServiceProvider();
        var mapper = provider.GetRequiredService<IApplicationMapper>();

        var exception = Assert.Throws<InvalidOperationException>(() => mapper.Map<SampleSource, Guid>(
            new SampleSource { Text = "x" }));

        Assert.That(exception!.Message, Does.Contain(nameof(SampleSource)));
        Assert.That(exception.Message, Does.Contain(nameof(Guid)));
    }

    [Test]
    public void DiscoversAdditionalAssemblyWithoutChangingMapper()
    {
        using var provider = new ServiceCollection()
            .AddApplicationMapper(typeof(IApplicationMapper).Assembly, typeof(SampleProfile).Assembly)
            .BuildServiceProvider();

        var mapped = provider.GetRequiredService<IApplicationMapper>()
            .Map<SampleSource, SampleDestination>(new SampleSource { Text = "future" });

        Assert.That(mapped.Value, Is.EqualTo("Mapped: future"));
    }

    [Test]
    public void DuplicatePairFailsDuringRegistration()
    {
        var services = new ServiceCollection();

        var exception = Assert.Throws<InvalidOperationException>(() => services.AddApplicationMapper(
            typeof(SampleProfile).Assembly, typeof(SampleProfile).Assembly));

        Assert.That(exception!.Message, Does.Contain(nameof(SampleSource)));
        Assert.That(exception.Message, Does.Contain(nameof(SampleDestination)));
    }
}

public sealed class SampleSource
{
    public required string Text { get; init; }
}

public sealed class SampleDestination
{
    public string Value { get; set; } = "";
    public int Length { get; set; }
}

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
