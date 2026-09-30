# Design

## Context

See [proposal.md](proposal.md) for the motivation and [application-mapping spec](specs/application-mapping/spec.md) for behavior. Today `MappingProfiles` contains only `CreateMap<Event, Event>()`; `EditEvent.Handler` maps the incoming event over an EF Core tracked event and saves it. `Program.cs` registers AutoMapper by scanning the Application assembly, and `EventsHub.Application.csproj` references AutoMapper 14.0.0. There are no existing mapper tests or OpenSpec capability specs.

## Goals / Non-Goals

**Goals:**
- Keep mapping rules explicit and strongly typed while preserving in-place updates of tracked entities.
- Let a developer add a mapping pair in a supplied assembly without editing the dispatcher.
- Detect duplicate pair registrations at startup and report unsupported pairs clearly at use time.

**Non-Goals:**
- Reproduce AutoMapper's `Profile`, `CreateMap`, conventions, projections, nested object graphs, or expression translation.
- Change event endpoints, database schema, or introduce DTOs in this change.
- Support in-place updates of immutable destination types; a future immutable mapping needs a separately designed contract.

## Decisions

### 1. One typed class per source/destination pair

Define an application-owned `IMapProfile<TSource, TDestination>` with operations to create a destination and apply values to an existing destination. The profile writes assignments explicitly; `EventToEventProfile` lists all current `Event` properties and mutates the supplied destination in place. The mapper exposes typed create and existing-destination operations through `IApplicationMapper`, so the edit handler no longer imports AutoMapper. A profile creates objects itself, avoiding a `new()` constraint on future destination types.

We considered manual assignments inside `EditEvent.Handler`, but that provides no reusable registration path for future pairs. We also considered a `CreateMap`-style configuration API, but it would recreate convention-driven behavior and a substantial part of AutoMapper.

### 2. Discover profiles once during service registration

Add an Application-layer registration extension that scans explicitly supplied assemblies (initially the Application assembly) for concrete closed `IMapProfile<,>` implementations. Build a type-pair registry once, fail immediately if a pair appears twice, and register the mapper and stateless profiles in dependency injection. The mapper resolves the pair from this registry; it never copies properties by reflection. Future profiles in scanned assemblies require no edits to the dispatcher. Allow an additional assembly to be supplied when a new module owns profiles.

We considered a hard-coded switch for the current `Event` pair, but every later pair would require dispatcher changes. Startup-only scanning keeps runtime mapping predictable while avoiding that maintenance cost.

### 3. Preserve the tracked destination during edits

`EditEvent.Handler` continues to load the existing `Event` with `FindAsync` and save through the same `AppDbContext`. It invokes the in-place mapper operation with the request as source and tracked object as destination. The `Event` profile copies all ten current properties, including `Id` (which matches the lookup key), without replacing the tracked reference. Mapping failure happens before `SaveChangesAsync`.

We considered mapping to a new `Event` and attaching it, but that changes EF Core tracking and concurrency behavior for no requested benefit.

### 4. Fail explicitly for invalid configuration or requests

A missing pair raises a mapping exception containing both type names; duplicate pairs stop startup during registration. Reject null source or existing destination arguments. No convention fallback occurs. Tests cover each failure and a second test-only profile to prove extensibility.

## Risks / Trade-offs

- **Manual profiles can omit a property** → Test every `Event` property against the destination after mapping; update the profile and test whenever the domain type changes.
- **Assembly scanning can overlook a profile in another module** → Require modules to pass their assembly to the registration extension and test that DI resolves a test profile from an additional assembly.
- **A profile can mutate a destination before throwing** → Keep profiles free of side effects and validate inputs before assignments; the edit operation only saves after successful mapping.
- **Existing tests do not exercise `EditEvent.Handler`** → Add a focused test using an EF Core tracked entity and verify persisted values after the handler saves.

## Migration Plan

1. Add mapper/profile contracts, registry, registration extension, and focused mapper tests in the Application layer.
2. Replace the AutoMapper `Event` profile with explicit assignments, then migrate `EditEvent.Handler` and API service registration.
3. Remove the AutoMapper package reference and verify the solution builds, mapper tests pass, and event edit behavior stays the same.
4. If the migration must be reverted before release, restore the previous package, profile, handler injection, and registration together; no data migration is required.
