# Tasks

## 1. Typed mapper foundation

- [x] 1.1 Add `IApplicationMapper` and `IMapProfile<TSource, TDestination>` contracts plus create and in-place dispatch in the Application layer; verify unit tests cover both operations, null arguments, and an unregistered pair error naming both types.
- [x] 1.2 Add DI registration that discovers profiles in supplied assemblies and rejects duplicate source/destination pairs during registration; verify tests resolve a second test profile from an additional assembly without dispatcher changes and fail on a duplicate pair.
- [x] 1.3 Document how to write and register a typed profile in `docs/guides/`; verify the documented example matches the test profile and its registration test passes.

## 2. Replace the current Event mapping

- [x] 2.1 Replace the AutoMapper `MappingProfiles` class with an explicit `Event`-to-`Event` profile; verify tests cover creation, all ten mapped properties, and preservation of an existing destination reference.
- [x] 2.2 Inject the application mapper into `EditEvent.Handler` and keep mapping on the EF Core tracked entity; verify a handler test reloads the saved event and observes all edited values on the same entity rather than an attached replacement.
- [x] 2.3 Replace `AddAutoMapper` in `Program.cs` with the new registration and remove the AutoMapper package from `EventsHub.Application.csproj`; verify the application builds and `rg AutoMapper src` finds no remaining source or project-file usage.

## 3. Integration verification

- [x] 3.1 Run `dotnet build EventsHub.slnx` and `dotnet test tests/EventsHub.UnitTests/EventsHub.UnitTests.csproj`; verify both succeed and the existing event controller tests still pass.
- [x] 3.2 If `graphify-out/graph.json` exists, run `graphify update .`; verify the graph reports the new mapper types and no longer reports an AutoMapper source dependency.
