using EventsHub.API.Controllers;
using EventsHub.Application.Events.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EventsHub.UnitTests.Controllers;

[TestFixture]
public class EventsControllerTests
{
    private EventsController _eventsController = null!;
    private ServiceProvider _services = null!;

    [SetUp]
    public void Setup()
    {
        _services = new ServiceCollection()
            .AddSingleton(GlobalTestSetup.AppDbContext)
            .AddLogging()
            .AddMediatR(config => config.RegisterServicesFromAssemblyContaining<GetEventList.Handler>())
            .BuildServiceProvider();
        _eventsController = new EventsController
        {
            ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext { RequestServices = _services }
            }
        };
    }

    [TearDown]
    public void TearDown() => _services.Dispose();

    [Test]
    public async Task GetEventsAsync_WhenEventsExists_ReturnAllEvents()
    {
        var expectedCount = await GlobalTestSetup.AppDbContext.Events.CountAsync();

        var result = await _eventsController.GetEventsAsync(CancellationToken.None);

        Assert.That(result.Value, Is.Not.Null);
        Assert.That(result.Value, Has.Count.EqualTo(expectedCount));
    }

    [Test]
    public async Task GetEventDetailAsync_WhenEventExists_ReturnMatchingEvent()
    {
        var existing = await GlobalTestSetup.AppDbContext.Events.FirstAsync();

        var result = await _eventsController.GetEventDetailAsync(existing.Id);

        Assert.That(result.Value, Is.Not.Null);
        Assert.Multiple(() =>
        {
            Assert.That(result.Value.Id, Is.EqualTo(existing.Id));
            Assert.That(result.Value.Title, Is.EqualTo(existing.Title));
        });
    }

    [Test]
    public void GetEventDetailAsync_WhenEventDoesntExist_ThrowsNotFoundError()
    {
        var nonExistentId = Guid.NewGuid().ToString();

        var exception = Assert.ThrowsAsync<Exception>(() =>
            _eventsController.GetEventDetailAsync(nonExistentId));

        Assert.That(exception!.Message, Is.EqualTo("Activity not found"));
    }
}
