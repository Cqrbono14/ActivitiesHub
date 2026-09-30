# Spec Delta

## Purpose

Provide predictable, application-owned object mapping so current entity updates and future source/destination pairs use explicit, testable mapping behavior.

## ADDED Requirements

### Requirement: Typed profiles define mappings explicitly
The application SHALL use a typed mapping profile for each supported source/destination type pair. A profile SHALL explicitly determine destination values rather than silently copying matching property names. A new profile SHALL be usable without changing the central mapper implementation.

#### Scenario: Future type pair is added
- **WHEN** a developer registers a typed profile for a previously unsupported source/destination pair
- **THEN** mapping that pair invokes the new profile and produces its explicitly defined values

#### Scenario: New destination is requested
- **WHEN** a caller requests a new destination for a registered source/destination pair
- **THEN** the profile creates and returns a destination populated according to its explicit mapping rules

### Requirement: Existing destination instances remain in place
The application SHALL support mapping into an existing destination object and SHALL preserve that destination object's identity while applying the registered profile.

#### Scenario: Event edit updates a tracked entity
- **WHEN** an event edit supplies an `Event` whose identifier matches an entity tracked by the database context
- **THEN** the registered `Event`-to-`Event` profile updates that same tracked entity's `Id`, `Title`, `Date`, `Description`, `Category`, `IsCancelled`, `City`, `Venue`, `Latitude`, and `Longitude` values from the request, and the edit persists through the existing save operation

### Requirement: Unsupported or ambiguous mappings fail clearly
The application SHALL reject a mapping request when no profile exists for its source/destination pair and SHALL reject duplicate profile registrations for the same pair. It SHALL NOT silently fall back to convention-based property copying.

#### Scenario: Mapping pair is missing
- **WHEN** a caller requests a source/destination pair with no registered profile
- **THEN** the mapping operation fails with an error identifying the unsupported pair

#### Scenario: Mapping pair is registered twice
- **WHEN** application startup discovers two profiles for the same source/destination pair
- **THEN** startup fails with an error identifying the conflicting pair
