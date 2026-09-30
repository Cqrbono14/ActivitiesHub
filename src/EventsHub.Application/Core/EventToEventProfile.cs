using EventsHub.Domain;

namespace EventsHub.Application.Core;

public sealed class EventToEventProfile : IMapProfile<Event, Event>
{
    public Event Create(Event source)
    {
        var destination = new Event
        {
            Title = source.Title,
            Description = source.Description,
            Category = source.Category,
            City = source.City,
            Venue = source.Venue,
            Latitude = source.Latitude,
            Longitude = source.Longitude
        };

        Apply(source, destination);
        return destination;
    }

    public void Apply(Event source, Event destination)
    {
        destination.Id = source.Id;
        destination.Title = source.Title;
        destination.Date = source.Date;
        destination.Description = source.Description;
        destination.Category = source.Category;
        destination.IsCancelled = source.IsCancelled;
        destination.City = source.City;
        destination.Venue = source.Venue;
        destination.Latitude = source.Latitude;
        destination.Longitude = source.Longitude;
    }
}
