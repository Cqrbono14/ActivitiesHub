using EventsHub.Application.Core;
using EventsHub.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace EventsHub.UnitTests.Mapping;

[TestFixture]
public class EventToEventProfileTests
{
    [Test]
    public void CreateCopiesAllEventProperties()
    {
        using var provider = new ServiceCollection().AddApplicationMapper().BuildServiceProvider();
        var source = MakeEvent("source");

        var mapped = provider.GetRequiredService<IApplicationMapper>().Map<Event, Event>(source);

        Assert.That(mapped, Is.Not.SameAs(source));
        AssertMatches(source, mapped);
    }

    [Test]
    public void ApplyCopiesAllPropertiesIntoSameDestination()
    {
        using var provider = new ServiceCollection().AddApplicationMapper().BuildServiceProvider();
        var source = MakeEvent("source");
        var destination = MakeEvent("destination");

        provider.GetRequiredService<IApplicationMapper>().Map(source, destination);

        AssertMatches(source, destination);
    }

    private static Event MakeEvent(string suffix) => new()
    {
        Id = $"id-{suffix}",
        Title = $"title-{suffix}",
        Date = suffix == "source" ? new DateTime(2030, 1, 2) : new DateTime(2020, 3, 4),
        Description = $"description-{suffix}",
        Category = $"category-{suffix}",
        IsCancelled = suffix == "source",
        City = $"city-{suffix}",
        Venue = $"venue-{suffix}",
        Latitude = $"latitude-{suffix}",
        Longitude = $"longitude-{suffix}"
    };

    private static void AssertMatches(Event source, Event destination)
    {
        Assert.Multiple(() =>
        {
            Assert.That(destination.Id, Is.EqualTo(source.Id));
            Assert.That(destination.Title, Is.EqualTo(source.Title));
            Assert.That(destination.Date, Is.EqualTo(source.Date));
            Assert.That(destination.Description, Is.EqualTo(source.Description));
            Assert.That(destination.Category, Is.EqualTo(source.Category));
            Assert.That(destination.IsCancelled, Is.EqualTo(source.IsCancelled));
            Assert.That(destination.City, Is.EqualTo(source.City));
            Assert.That(destination.Venue, Is.EqualTo(source.Venue));
            Assert.That(destination.Latitude, Is.EqualTo(source.Latitude));
            Assert.That(destination.Longitude, Is.EqualTo(source.Longitude));
        });
    }
}
