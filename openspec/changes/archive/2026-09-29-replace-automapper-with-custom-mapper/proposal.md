# Proposal

## Why

EventsHub uses AutoMapper for one `Event`-to-`Event` update, but this dependency determines how every future mapping profile must be written. A small, explicit mapping contract will preserve the current edit behavior while letting developers add and test future profiles without AutoMapper.

## What Changes

- Add an application-owned mapper and typed profile contract. Each profile explicitly assigns destination values for one source/destination type pair; additional profiles can be registered without changing the mapper dispatcher.
- Replace the current `CreateMap<Event, Event>()` profile with explicit assignments that update the existing EF Core tracked `Event` instance.
- Register the mapper and profiles through dependency injection, then migrate `EditEvent.Handler` to the new contract.
- Remove AutoMapper registration and its package reference. **BREAKING (internal):** application code that derives from AutoMapper `Profile` or injects AutoMapper `IMapper` must use the new contracts.
- Add focused tests for current mapping behavior, an additional test profile, profile resolution, and unsupported mappings.

## Capabilities

### New Capabilities

- `application-mapping`: Typed, explicit, extensible mapping between application object pairs, including updates to an existing destination instance.

### Modified Capabilities

- None. The project has no existing OpenSpec capability specs.

## Impact

- `src/EventsHub.Application/Core/MappingProfiles.cs`, `Events/Commands/EditEvent.cs`, and `EventsHub.Application.csproj`.
- `src/EventsHub.API/Program.cs` dependency injection setup.
- Unit tests for mapper dispatch and `EditEvent` persistence behavior.
- No intended change to the HTTP API or persisted `Event` shape.
