# Graph Report - EventsHub  (2026-09-29)

## Corpus Check
- 82 files · ~60,854 words
- Verdict: corpus is large enough that graph structure adds value.
- Unclassified: 11 file(s) not represented in the graph (top: (none) 8, .css 2, .nswag 1)

## Summary
- 609 nodes · 795 edges · 59 communities (35 shown, 24 thin omitted)
- Extraction: 93% EXTRACTED · 7% INFERRED · 0% AMBIGUOUS · INFERRED: 52 edges (avg confidence: 0.92)
- Token cost: 0 input · 0 output

## Graph Freshness
- Built from commit: `99992926`
- Run `git rev-parse HEAD` and compare to check if the graph is stale.
- Run `graphify update .` after code changes (no API cost).

## Community Hubs (Navigation)
- package.json
- EventsHub.Persistence
- Graphify
- .NET 10 Web API backend
- EventsHub.UnitTests.csproj
- .GetEventsAsync
- baseUri = https://localhost:5001/api/v1
- 20260829022218_InitialCreate.Designer.cs
- compilerOptions
- Command
- devDependencies
- compilerOptions
- AppDbContext
- Event
- IApplicationMapper
- .HandlerUpdatesTrackedEntityAndPersistsEveryMappedValue
- https
- Vite
- EventsHub.OpenApi
- WeatherForecast
- Git branch
- openspec-explore/SKILL.md
- ADDED Requirements
- Handler
- Domain event
- EventsHub.Domain layer
- Layered platform illustration
- tsconfig.json
- FalkorDB export
- GraphML export
- Vite
- index.d.ts
- Result pattern
- FluentValidation
- EventsHub
- Purple lightning bolt favicon
- Bluesky icon
- Discord icon
- Documentation icon
- GitHub icon
- Social icon
- X icon
- React logo
- Clean Architecture
- EF Core DbContext
- Software testing
- AppDbContext
- automapper
- system_runtime_compilerservices
- Handler
- Proposal
- IRequest
- .CreateCopiesAllEventProperties
- Tasks

## God Nodes (most connected - your core abstractions)
1. `Event` - 44 edges
2. `compilerOptions` - 18 edges
3. `IApplicationMapper` - 15 edges
4. `compilerOptions` - 15 edges
5. `AppDbContext` - 14 edges
6. `Handler` - 13 edges
7. `EventsHub.Persistence` - 12 edges
8. `EventsHub.Application.Core` - 11 edges
9. `EventsHub.Domain` - 11 edges
10. `Graphify` - 10 edges

## Surprising Connections (you probably didn't know these)
- `1. Typed mapper foundation` --references--> `IApplicationMapper`  [INFERRED]
  openspec/changes/replace-automapper-with-custom-mapper/tasks.md → src/EventsHub.Application/Core/IApplicationMapper.cs
- `2. Discover profiles once during service registration` --references--> `Event`  [INFERRED]
  openspec/changes/replace-automapper-with-custom-mapper/design.md → src/EventsHub.Domain/Event.cs
- `Why` --references--> `Event`  [INFERRED]
  openspec/changes/replace-automapper-with-custom-mapper/proposal.md → src/EventsHub.Domain/Event.cs
- `Scenario: Event edit updates a tracked entity` --references--> `Event`  [INFERRED]
  openspec/changes/replace-automapper-with-custom-mapper/specs/application-mapping/spec.md → src/EventsHub.Domain/Event.cs
- `1. One typed class per source/destination pair` --references--> `EventToEventProfile`  [INFERRED]
  openspec/changes/replace-automapper-with-custom-mapper/design.md → src/EventsHub.Application/Core/EventToEventProfile.cs

## Import Cycles
- None detected.

## Hyperedges (group relationships)
- **EventsHub event read flow** — docs_architecture_web_frontend, docs_architecture_api_backend, docs_architecture_events_controller, docs_architecture_appdbcontext, docs_architecture_sqlite_database [EXTRACTED 1.00]
- **Graphify extraction pipeline** — _agents_skills_graphify_skill_structural_extraction, _agents_skills_graphify_skill_semantic_extraction, _agents_skills_graphify_skill_graph_merge, _agents_skills_graphify_skill_community_detection [EXTRACTED 1.00]
- **SVG icon sprite** — web_public_icons_bluesky_icon, web_public_icons_discord_icon, web_public_icons_documentation_icon, web_public_icons_github_icon, web_public_icons_social_icon, web_public_icons_x_icon [EXTRACTED 1.00]

## Communities (59 total, 24 thin omitted)

### Community 0 - "package.json"
Cohesion: 0.05
Nodes (45): axios, @babel/core, babel-plugin-react-compiler, @emotion/react, @emotion/styled, eslint, @eslint/js, eslint-plugin-react-hooks (+37 more)

### Community 1 - "EventsHub.Persistence"
Cohesion: 0.06
Nodes (32): ControllerBase, EventsHub.API.Controllers, EventsHub.Domain, EventsHub.Application.Events.Queries, EventsHub.Application.Events.Commands, EventsHub.UnitTests, EventsHub.Persistence, EventsHub.UnitTests.Controllers (+24 more)

### Community 2 - "Graphify"
Cohesion: 0.06
Nodes (37): Add URL to corpus, Watch mode, Graphify MCP server, Wiki export, Relationship confidence provenance, Deterministic node IDs, Semantic extraction JSON schema, Hyperedges (+29 more)

### Community 3 - ".NET 10 Web API backend"
Cohesion: 0.20
Nodes (11): .NET 10 Web API backend, CORS development origins, Generated API artifacts, EventsHub.OpenApi host, Idempotent event seeding, React and Vite frontend, Generated C# API client, Local NSwag CLI tool (+3 more)

### Community 4 - "EventsHub.UnitTests.csproj"
Cohesion: 0.08
Nodes (25): coverlet.collector (6.0.4), MediatR (14.2.0), Microsoft.AspNetCore.Mvc.NewtonsoftJson (10.0.11), Microsoft.AspNetCore.OpenApi (10.0.11), Microsoft.EntityFrameworkCore.Design (10.0.11), Microsoft.EntityFrameworkCore.Sqlite (10.0.11), Microsoft.NET.Test.Sdk (17.14.0), Moq (4.20.72) (+17 more)

### Community 5 - ".GetEventsAsync"
Cohesion: 0.12
Nodes (18): ActionResult, Exception, Handler, HttpDelete, HttpPost, HttpPut, IReadOnlyList, ProducesResponseType (+10 more)

### Community 6 - "baseUri = https://localhost:5001/api/v1"
Cohesion: 0.10
Nodes (25): baseUri = https://localhost:5001/api/v1, 404 Not Found: The event was not found, POST /events/, Events - Create - 200, 404 Not Found: The event was not found, DELETE /events/:eventId, Events - Delete - 200, 404 Not Found: The event was not found (+17 more)

### Community 7 - "20260829022218_InitialCreate.Designer.cs"
Cohesion: 0.12
Nodes (15): EventsHub.Persistence.Migrations, microsoft_entityframeworkcore_infrastructure, microsoft_entityframeworkcore_migrations, microsoft_entityframeworkcore_storage_valueconversion, Migration, MigrationBuilder, ModelSnapshot, DateTime (+7 more)

### Community 8 - "compilerOptions"
Cohesion: 0.10
Nodes (19): compilerOptions, allowArbitraryExtensions, allowImportingTsExtensions, erasableSyntaxOnly, jsx, lib, module, moduleDetection (+11 more)

### Community 9 - "Command"
Cohesion: 0.22
Nodes (10): Application layer, CQRS, Command, Command Query Responsibility Segregation, Dispatcher and handlers, Idempotency, Pipeline behavior, Query (+2 more)

### Community 10 - "devDependencies"
Cohesion: 0.11
Nodes (18): devDependencies, @babel/core, babel-plugin-react-compiler, eslint, @eslint/js, eslint-plugin-react-hooks, eslint-plugin-react-refresh, globals (+10 more)

### Community 11 - "compilerOptions"
Cohesion: 0.12
Nodes (16): compilerOptions, allowImportingTsExtensions, erasableSyntaxOnly, lib, module, moduleDetection, noEmit, noFallthroughCasesInSwitch (+8 more)

### Community 12 - "AppDbContext"
Cohesion: 0.17
Nodes (13): Command, DbContext, DbContextOptions, DbSet, IRequestHandler, CancellationToken, Task, Handler (+5 more)

### Community 13 - "Event"
Cohesion: 0.14
Nodes (14): EventToEventProfile, DateTime, Event, Category, City, Date, Description, Id (+6 more)

### Community 14 - "IApplicationMapper"
Cohesion: 0.07
Nodes (26): ArgumentNullException, EventsHub.UnitTests.Mapping, EventsHub.Application.Core, Application mapping, Guid, HashSet, InvalidOperationException, IServiceCollection (+18 more)

### Community 15 - ".HandlerUpdatesTrackedEntityAndPersistsEveryMappedValue"
Cohesion: 0.19
Nodes (8): OneTimeSetUp, OneTimeTearDown, Task, GlobalTestSetup, AppDbContext, Task, Test, EditEventMappingTests

### Community 16 - "https"
Cohesion: 0.20
Nodes (9): ASPNETCORE_ENVIRONMENT, applicationUrl, commandName, dotnetRunMessages, environmentVariables, launchBrowser, profiles, https (+1 more)

### Community 17 - "Vite"
Cohesion: 0.20
Nodes (10): Events Hub HTML page, ./src/main.tsx module entry, React root element, React, React Compiler, TypeScript, Type aware ESLint rules, Vite (+2 more)

### Community 18 - "EventsHub.OpenApi"
Cohesion: 0.22
Nodes (8): ASPNETCORE_ENVIRONMENT, applicationUrl, commandName, environmentVariables, launchBrowser, profiles, EventsHub.OpenApi, $schema

### Community 19 - "WeatherForecast"
Cohesion: 0.25
Nodes (7): EventsHub.API, DateOnly, WeatherForecast, Date, Summary, TemperatureC, TemperatureF

### Community 20 - "Git branch"
Cohesion: 0.25
Nodes (8): Git branch, Cherry-pick, Git commit, Git, Git merge, Pull request, Squash, Stash

### Community 21 - "openspec-explore/SKILL.md"
Cohesion: 0.17
Nodes (11): Check for context, Ending Discovery, Guardrails, Handling Different Entry Points, OpenSpec Awareness, Planning a Change, The Stance, What You Don't Have To Do (+3 more)

### Community 22 - "ADDED Requirements"
Cohesion: 0.14
Nodes (11): ADDED Requirements, Purpose, Requirement: Existing destination instances remain in place, Requirement: Typed profiles define mappings explicitly, Requirement: Unsupported or ambiguous mappings fail clearly, Scenario: Event edit updates a tracked entity, Scenario: Future type pair is added, Scenario: Mapping pair is missing (+3 more)

### Community 23 - "Handler"
Cohesion: 0.19
Nodes (13): 1. One typed class per source/destination pair, 2. Discover profiles once during service registration, 3. Preserve the tracked destination during edits, 4. Fail explicitly for invalid configuration or requests, Context, Decisions, Design, Goals / Non-Goals (+5 more)

### Community 24 - "Domain event"
Cohesion: 0.40
Nodes (5): Domain event, Event sourcing, Eventual consistency, Outbox pattern, Saga and process manager

### Community 25 - "EventsHub.Domain layer"
Cohesion: 0.67
Nodes (3): EventsHub.Application layer, EventsHub.Domain layer, EventsHub.Persistence layer

### Community 26 - "Layered platform illustration"
Cohesion: 1.00
Nodes (3): Layered platform illustration, Lower purple gradient rounded diamond layer, Upper outlined rounded diamond layer

### Community 43 - "Clean Architecture"
Cohesion: 0.22
Nodes (9): Architecture tests, Clean Architecture, Dependency injection and composition root, Dependency Rule, Domain layer, DTO and mapping boundary, Infrastructure and Persistence layer, Presentation and API layer (+1 more)

### Community 44 - "EF Core DbContext"
Cohesion: 0.22
Nodes (9): Change tracking, Concurrency control, EF Core DbContext, DbSet, DbContext lifetime, Entity loading strategies, Query optimization, SaveChanges (+1 more)

### Community 45 - "Software testing"
Cohesion: 0.25
Nodes (8): Arrange Act Assert, CI and CD testing, Code coverage, Flaky tests, Software testing, Test-driven development, Test doubles, Testing pyramid

### Community 46 - "AppDbContext"
Cohesion: 0.33
Nodes (6): AppDbContext, Clean Architecture implementation gap, Controller-to-EF Core access, Event entity, EventsController, SQLite eventshub.db

### Community 54 - "Handler"
Cohesion: 0.21
Nodes (11): ILogger, List, Query, CancellationToken, Task, Handler, CancellationToken, Task (+3 more)

### Community 55 - "Proposal"
Cohesion: 0.25
Nodes (8): Capabilities, Impact, Modified Capabilities, New Capabilities, Proposal, What Changes, Why, EditEvent

### Community 56 - "IRequest"
Cohesion: 0.33
Nodes (6): IRequest, Command, Event, CreateEvent, Command, Event

### Community 58 - "Tasks"
Cohesion: 0.40
Nodes (4): 1. Typed mapper foundation, 2. Replace the current Event mapping, 3. Integration verification, Tasks

## Knowledge Gaps
- **248 isolated node(s):** `Mediator`, `net10.0`, `Microsoft.AspNetCore.OpenApi (10.0.11)`, `Microsoft.EntityFrameworkCore.Design (10.0.11)`, `Microsoft.NET.Sdk.Web` (+243 more)
  These have ≤1 connection - possible missing edges or undocumented components. (Counts symbols only; 323 node(s) total have ≤1 connection when file, concept and rationale nodes are included.)
- **24 thin communities (<3 nodes) omitted from report** — run `graphify query` to explore isolated nodes.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **Why does `Event` connect `Event` to `EventsHub.Persistence`, `.GetEventsAsync`, `AppDbContext`, `.HandlerUpdatesTrackedEntityAndPersistsEveryMappedValue`, `Handler`, `ADDED Requirements`, `Proposal`, `IRequest`, `Handler`, `Tasks`, `.CreateCopiesAllEventProperties`?**
  _High betweenness centrality (0.082) - this node is a cross-community bridge._
- **Why does `AppDbContext` connect `AppDbContext` to `EventsHub.Persistence`, `Event`, `.HandlerUpdatesTrackedEntityAndPersistsEveryMappedValue`, `Handler`, `Handler`?**
  _High betweenness centrality (0.034) - this node is a cross-community bridge._
- **Why does `IApplicationMapper` connect `IApplicationMapper` to `.CreateCopiesAllEventProperties`, `Tasks`, `.HandlerUpdatesTrackedEntityAndPersistsEveryMappedValue`, `Handler`?**
  _High betweenness centrality (0.030) - this node is a cross-community bridge._
- **Are the 10 inferred relationships involving `Event` (e.g. with `1. One typed class per source/destination pair` and `2. Discover profiles once during service registration`) actually correct?**
  _`Event` has 10 INFERRED edges - model-reasoned connections that need verification._
- **Are the 3 inferred relationships involving `IApplicationMapper` (e.g. with `Application mapping` and `1. One typed class per source/destination pair`) actually correct?**
  _`IApplicationMapper` has 3 INFERRED edges - model-reasoned connections that need verification._
- **What connects `Mediator`, `net10.0`, `Microsoft.AspNetCore.OpenApi (10.0.11)` to the rest of the system?**
  _248 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `package.json` be split into smaller, more focused modules?**
  _Cohesion score 0.05142857142857143 - nodes in this community are weakly interconnected._