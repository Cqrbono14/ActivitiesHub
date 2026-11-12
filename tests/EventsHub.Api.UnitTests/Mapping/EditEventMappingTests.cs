using EventsHub.Application.Core;
using EventsHub.Application.Events.Commands;
using EventsHub.Domain;
using EventsHub.Persistence;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EventsHub.UnitTests.Mapping;

[TestFixture]
public class EditEventMappingTests
{
    [Test]
    public async Task HandlerUpdatesTrackedEntityAndPersistsEveryMappedValue()
    {
        await using var connection = new SqliteConnection("DataSource=:memory:");
        await connection.OpenAsync();
        var options = new DbContextOptionsBuilder<AppDbContext>().UseSqlite(connection).Options;
        await using var context = new AppDbContext(options);
        await context.Database.EnsureCreatedAsync();
        var original = MakeEvent("before");
        context.Events.Add(original);
        await context.SaveChangesAsync();

        var tracked = await context.Events.FindAsync(original.Id);
        var edited = MakeEvent("after");
        edited.Id = original.Id;
        using var provider = new ServiceCollection().AddApplicationMapper().BuildServiceProvider();
        var handler = new EditEvent.Handler(context, provider.GetRequiredService<IApplicationMapper>());

        await handler.Handle(new EditEvent.Command { Event = edited }, CancellationToken.None);

        Assert.That(tracked, Is.SameAs(original));
        Assert.That(context.Events.Local.Single(), Is.SameAs(tracked));
        AssertMatches(edited, tracked!);

        context.ChangeTracker.Clear();
        var reloaded = await context.Events.SingleAsync(@event => @event.Id == edited.Id);
        AssertMatches(edited, reloaded);
    }

    private static Event MakeEvent(string suffix) => new()
    {
        Title = $"title-{suffix}",
        Date = suffix == "before" ? new DateTime(2025, 1, 2) : new DateTime(2030, 3, 4),
        Description = $"description-{suffix}",
        Category = $"category-{suffix}",
        IsCancelled = suffix == "after",
        City = $"city-{suffix}",
        Venue = $"venue-{suffix}",
        Latitude = $"latitude-{suffix}",
        Longitude = $"longitude-{suffix}"
    };

    private static void AssertMatches(Event expected, Event actual)
    {
        Assert.Multiple(() =>
        {
            Assert.That(actual.Id, Is.EqualTo(expected.Id));
            Assert.That(actual.Title, Is.EqualTo(expected.Title));
            Assert.That(actual.Date, Is.EqualTo(expected.Date));
            Assert.That(actual.Description, Is.EqualTo(expected.Description));
            Assert.That(actual.Category, Is.EqualTo(expected.Category));
            Assert.That(actual.IsCancelled, Is.EqualTo(expected.IsCancelled));
            Assert.That(actual.City, Is.EqualTo(expected.City));
            Assert.That(actual.Venue, Is.EqualTo(expected.Venue));
            Assert.That(actual.Latitude, Is.EqualTo(expected.Latitude));
            Assert.That(actual.Longitude, Is.EqualTo(expected.Longitude));
        });
    }
}
