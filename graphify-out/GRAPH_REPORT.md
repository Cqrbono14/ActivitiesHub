# Graph Report - EventsHub  (2026-11-17)

## Corpus Check
- 111 files · ~131,151 words
- Verdict: corpus is large enough that graph structure adds value.
- Unclassified: 16 file(s) not represented in the graph (top: (none) 12, .scss 2, .nswag 1)

## Summary
- 819 nodes · 1162 edges · 66 communities (41 shown, 25 thin omitted)
- Extraction: 94% EXTRACTED · 6% INFERRED · 0% AMBIGUOUS · INFERRED: 69 edges (avg confidence: 0.9)
- Token cost: 0 input · 0 output

## Graph Freshness
- Built from commit: `efadfbde`
- Run `git rev-parse HEAD` and compare to check if the graph is stale.
- Run `graphify update .` after code changes (no API cost).

## Community Hubs (Navigation)
- package.json
- EventsHub.Persistence
- Graphify
- .NET 10 Web API backend
- EventsHub.Api.UnitTests.csproj
- EventsControllerTests
- baseUri = https://localhost:5001/api/v1
- Handler
- compilerOptions
- dependencies
- devDependencies
- compilerOptions
- AppDbContext
- Event
- IApplicationMapper
- ADDED Requirements
- https
- Vite
- EventsHub.OpenApi
- WeatherForecast
- Git branch
- openspec-explore/SKILL.md
- Requirements
- HandlerTestBase
- Domain event
- EventsHub.Domain layer
- @mui/material
- tsconfig.json
- FalkorDB export
- GraphML export
- Command
- index.d.ts
- Result pattern
- FluentValidation
- EventsHub
- Handler
- Part 1: .NET + npm in the same repo (e.g. EventsHub)
- Part 3: npm only, `package.json` in the repo root (Husky v9)
- IRequest
- .HandlerUpdatesTrackedEntityAndPersistsEveryMappedValue
- EventsHubBaseController
- 20260829022218_InitialCreate.Designer.cs
- Clean Architecture
- .CreateCopiesAllEventProperties
- web_src_index
- task-runner.json
- EF Core DbContext
- automapper
- system_runtime_compilerservices
- commit-msg
- pre-commit
- eventshub_api_controllers
- eventshub_application_events_queries
- Software testing
- Proposal
- eventshub_persistence
- system_collections_generic
- Tasks
- system_linq
- AppDbContext
- system_threading_tasks

## God Nodes (most connected - your core abstractions)
1. `Event` - 48 edges
2. `EventsControllerTests` - 18 edges
3. `compilerOptions` - 18 edges
4. `IApplicationMapper` - 17 edges
5. `AppDbContext` - 16 edges
6. `@mui/material` - 15 edges
7. `compilerOptions` - 15 edges
8. `EventsHub.Persistence` - 14 edges
9. `Part 1: .NET + npm in the same repo (e.g. EventsHub)` - 14 edges
10. `Part 2: .NET only (Husky.Net)` - 14 edges

## Surprising Connections (you probably didn't know these)
- `1. Typed mapper foundation` --references--> `IApplicationMapper`  [INFERRED]
  openspec/changes/archive/2026-09-29-replace-automapper-with-custom-mapper/tasks.md → src/EventsHub.Application/Core/IApplicationMapper.cs
- `2. Discover profiles once during service registration` --references--> `Event`  [INFERRED]
  openspec/changes/archive/2026-09-29-replace-automapper-with-custom-mapper/design.md → src/EventsHub.Domain/Event.cs
- `Why` --references--> `Event`  [INFERRED]
  openspec/changes/archive/2026-09-29-replace-automapper-with-custom-mapper/proposal.md → src/EventsHub.Domain/Event.cs
- `Scenario: Event edit updates a tracked entity` --references--> `Event`  [INFERRED]
  openspec/changes/archive/2026-09-29-replace-automapper-with-custom-mapper/specs/application-mapping/spec.md → src/EventsHub.Domain/Event.cs
- `Scenario: Event edit updates a tracked entity` --references--> `Event`  [INFERRED]
  openspec/specs/application-mapping/spec.md → src/EventsHub.Domain/Event.cs

## Import Cycles
- None detected.

## Hyperedges (group relationships)
- **EventsHub event read flow** — docs_architecture_web_frontend, docs_architecture_api_backend, docs_architecture_events_controller, docs_architecture_appdbcontext, docs_architecture_sqlite_database [EXTRACTED 1.00]
- **Graphify extraction pipeline** — _agents_skills_graphify_skill_structural_extraction, _agents_skills_graphify_skill_semantic_extraction, _agents_skills_graphify_skill_graph_merge, _agents_skills_graphify_skill_community_detection [EXTRACTED 1.00]

## Communities (66 total, 25 thin omitted)

### Community 0 - "package.json"
Cohesion: 0.06
Nodes (40): @babel/core, babel-plugin-react-compiler, @emotion/react, @emotion/styled, eslint, eslint-config-prettier, @eslint/js, eslint-plugin-react-hooks (+32 more)

### Community 1 - "EventsHub.Persistence"
Cohesion: 0.06
Nodes (32): EventsHub.API.Controllers, EventsHub.Domain, EventsHub.Application.UnitTests.Events, EventsHub.Application.Events.Queries, EventsHub.Api.UnitTests.Controllers, EventsHub.Application.Events.Commands, EventsHub.Persistence, EventsHub.Api.UnitTests (+24 more)

### Community 2 - "Graphify"
Cohesion: 0.06
Nodes (37): Add URL to corpus, Watch mode, Graphify MCP server, Wiki export, Relationship confidence provenance, Deterministic node IDs, Semantic extraction JSON schema, Hyperedges (+29 more)

### Community 3 - ".NET 10 Web API backend"
Cohesion: 0.20
Nodes (11): .NET 10 Web API backend, CORS development origins, Generated API artifacts, EventsHub.OpenApi host, Idempotent event seeding, React and Vite frontend, Generated C# API client, Local NSwag CLI tool (+3 more)

### Community 4 - "EventsHub.Api.UnitTests.csproj"
Cohesion: 0.06
Nodes (32): MediatR (14.2.0), Microsoft.AspNetCore.Mvc.NewtonsoftJson (10.0.11), Microsoft.AspNetCore.OpenApi (10.0.11), Microsoft.EntityFrameworkCore.Design (10.0.11), Microsoft.EntityFrameworkCore.Sqlite (10.0.11), Moq (4.20.72), Newtonsoft.Json (13.0.4), NSwag.AspNetCore (14.7.1) (+24 more)

### Community 5 - "EventsControllerTests"
Cohesion: 0.11
Nodes (22): ActionResult, Handler, HttpDelete, HttpPost, HttpPut, IReadOnlyList, NoContentResult, OkResult (+14 more)

### Community 6 - "baseUri = https://localhost:5001/api/v1"
Cohesion: 0.10
Nodes (25): baseUri = https://localhost:5001/api/v1, 404 Not Found: The event was not found, POST /events/, Events - Create - 200, 404 Not Found: The event was not found, DELETE /events/:eventId, Events - Delete - 200, 404 Not Found: The event was not found (+17 more)

### Community 7 - "Handler"
Cohesion: 0.27
Nodes (10): 2. Discover profiles once during service registration, 3. Preserve the tracked destination during edits, 4. Fail explicitly for invalid configuration or requests, Context, Decisions, Design, Goals / Non-Goals, Migration Plan (+2 more)

### Community 8 - "compilerOptions"
Cohesion: 0.10
Nodes (19): compilerOptions, allowArbitraryExtensions, allowImportingTsExtensions, erasableSyntaxOnly, jsx, lib, module, moduleDetection (+11 more)

### Community 9 - "dependencies"
Cohesion: 0.13
Nodes (15): dependencies, axios, date-fns, @emotion/react, @emotion/styled, @fontsource/roboto, @mui/icons-material, @mui/material (+7 more)

### Community 10 - "devDependencies"
Cohesion: 0.10
Nodes (21): devDependencies, @babel/core, babel-plugin-react-compiler, eslint, eslint-config-prettier, @eslint/js, eslint-plugin-react-hooks, eslint-plugin-react-refresh (+13 more)

### Community 11 - "compilerOptions"
Cohesion: 0.12
Nodes (16): compilerOptions, allowImportingTsExtensions, erasableSyntaxOnly, lib, module, moduleDetection, noEmit, noFallthroughCasesInSwitch (+8 more)

### Community 12 - "AppDbContext"
Cohesion: 0.17
Nodes (13): Command, DbContext, DbContextOptions, DbSet, IRequestHandler, CancellationToken, Task, Handler (+5 more)

### Community 13 - "Event"
Cohesion: 0.15
Nodes (14): 1. One typed class per source/destination pair, EventToEventProfile, DateTime, Event, Category, City, Date, Description (+6 more)

### Community 14 - "IApplicationMapper"
Cohesion: 0.09
Nodes (22): ArgumentNullException, Application mapping, Guid, HashSet, InvalidOperationException, IServiceCollection, IServiceProvider, ApplicationMapper (+14 more)

### Community 15 - "ADDED Requirements"
Cohesion: 0.17
Nodes (11): ADDED Requirements, Purpose, Requirement: Existing destination instances remain in place, Requirement: Typed profiles define mappings explicitly, Requirement: Unsupported or ambiguous mappings fail clearly, Scenario: Event edit updates a tracked entity, Scenario: Future type pair is added, Scenario: Mapping pair is missing (+3 more)

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

### Community 22 - "Requirements"
Cohesion: 0.17
Nodes (11): Application Mapping Specification, Purpose, Requirement: Existing destination instances remain in place, Requirement: Typed profiles define mappings explicitly, Requirement: Unsupported or ambiguous mappings fail clearly, Requirements, Scenario: Event edit updates a tracked entity, Scenario: Future type pair is added (+3 more)

### Community 23 - "HandlerTestBase"
Cohesion: 0.08
Nodes (25): DbUpdateException, OperationCanceledException, SqliteConnection, Task, Test, CreateEventTests, Exception, ServiceProvider (+17 more)

### Community 24 - "Domain event"
Cohesion: 0.40
Nodes (5): Domain event, Event sourcing, Eventual consistency, Outbox pattern, Saga and process manager

### Community 25 - "EventsHub.Domain layer"
Cohesion: 0.67
Nodes (3): EventsHub.Application layer, EventsHub.Domain layer, EventsHub.Persistence layer

### Community 26 - "@mui/material"
Cohesion: 0.09
Nodes (34): axios, date-fns, @fontsource/roboto, @mui/icons-material, @mui/material, react, react-dom, react-router (+26 more)

### Community 30 - "Command"
Cohesion: 0.22
Nodes (10): Application layer, CQRS, Command, Command Query Responsibility Segregation, Dispatcher and handlers, Idempotency, Pipeline behavior, Query (+2 more)

### Community 35 - "Handler"
Cohesion: 0.21
Nodes (11): ILogger, Query, CancellationToken, Task, Handler, CancellationToken, List, Task (+3 more)

### Community 36 - "Part 1: .NET + npm in the same repo (e.g. EventsHub)"
Cohesion: 0.04
Nodes (46): How to use this guide, Installing Husky in a Project: .NET and npm, Optional: add Prettier (code formatting), Optional: add Prettier (code formatting), Part 1: .NET + npm in the same repo (e.g. EventsHub), Part 2: .NET only (Husky.Net), Part 4: npm only, `package.json` in a subfolder (Husky v9), Skipping hooks (use sparingly) (+38 more)

### Community 37 - "Part 3: npm only, `package.json` in the repo root (Husky v9)"
Cohesion: 0.13
Nodes (15): Optional: add Prettier (code formatting), Part 3: npm only, `package.json` in the repo root (Husky v9), Skipping hooks (use sparingly), Step 10: Commit the Husky files, Step 11: Setup for a new teammate or CI, Step 1: Check prerequisites, Step 2: Make sure `package.json` and `.gitignore` exist, Step 3: Install Husky (+7 more)

### Community 38 - "IRequest"
Cohesion: 0.22
Nodes (9): IRequest, Impact, Command, Event, Command, Event, EditEvent, Query (+1 more)

### Community 39 - ".HandlerUpdatesTrackedEntityAndPersistsEveryMappedValue"
Cohesion: 0.19
Nodes (8): OneTimeSetUp, OneTimeTearDown, Task, GlobalTestSetup, AppDbContext, Task, Test, EditEventMappingTests

### Community 40 - "EventsHubBaseController"
Cohesion: 0.22
Nodes (8): ControllerBase, IEnumerable, IMediator, EventsHubBaseController, Mediator, HttpGet, WeatherForecastController, WeatherForecast

### Community 41 - "20260829022218_InitialCreate.Designer.cs"
Cohesion: 0.12
Nodes (15): EventsHub.Persistence.Migrations, microsoft_entityframeworkcore_infrastructure, microsoft_entityframeworkcore_migrations, microsoft_entityframeworkcore_storage_valueconversion, Migration, MigrationBuilder, ModelSnapshot, DateTime (+7 more)

### Community 42 - "Clean Architecture"
Cohesion: 0.22
Nodes (9): Architecture tests, Clean Architecture, Dependency injection and composition root, Dependency Rule, Domain layer, DTO and mapping boundary, Infrastructure and Persistence layer, Presentation and API layer (+1 more)

### Community 46 - "EF Core DbContext"
Cohesion: 0.22
Nodes (9): Change tracking, Concurrency control, EF Core DbContext, DbSet, DbContext lifetime, Entity loading strategies, Query optimization, SaveChanges (+1 more)

### Community 58 - "Software testing"
Cohesion: 0.25
Nodes (8): Arrange Act Assert, CI and CD testing, Code coverage, Flaky tests, Software testing, Test-driven development, Test doubles, Testing pyramid

### Community 59 - "Proposal"
Cohesion: 0.25
Nodes (6): Capabilities, Modified Capabilities, New Capabilities, Proposal, What Changes, Why

### Community 62 - "Tasks"
Cohesion: 0.40
Nodes (4): 1. Typed mapper foundation, 2. Replace the current Event mapping, 3. Integration verification, Tasks

### Community 64 - "AppDbContext"
Cohesion: 0.33
Nodes (6): AppDbContext, Clean Architecture implementation gap, Controller-to-EF Core access, Event entity, EventsController, SQLite eventshub.db

## Knowledge Gaps
- **326 isolated node(s):** `$schema`, `tasks`, `Mediator`, `net10.0`, `Microsoft.AspNetCore.OpenApi (10.0.11)` (+321 more)
  These have ≤1 connection - possible missing edges or undocumented components. (Counts symbols only; 426 node(s) total have ≤1 connection when file, concept and rationale nodes are included.)
- **25 thin communities (<3 nodes) omitted from report** — run `graphify query` to explore isolated nodes.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **Why does `Event` connect `Event` to `EventsHub.Persistence`, `Handler`, `EventsControllerTests`, `IRequest`, `Handler`, `.HandlerUpdatesTrackedEntityAndPersistsEveryMappedValue`, `.CreateCopiesAllEventProperties`, `AppDbContext`, `ADDED Requirements`, `Requirements`, `HandlerTestBase`, `Proposal`, `Tasks`?**
  _High betweenness centrality (0.073) - this node is a cross-community bridge._
- **Why does `AppDbContext` connect `AppDbContext` to `EventsHub.Persistence`, `Handler`, `EventsControllerTests`, `Handler`, `.HandlerUpdatesTrackedEntityAndPersistsEveryMappedValue`, `Event`, `HandlerTestBase`?**
  _High betweenness centrality (0.033) - this node is a cross-community bridge._
- **Why does `IApplicationMapper` connect `IApplicationMapper` to `EventsHub.Persistence`, `Handler`, `.HandlerUpdatesTrackedEntityAndPersistsEveryMappedValue`, `.CreateCopiesAllEventProperties`, `Event`, `HandlerTestBase`, `Tasks`?**
  _High betweenness centrality (0.026) - this node is a cross-community bridge._
- **Are the 11 inferred relationships involving `Event` (e.g. with `1. One typed class per source/destination pair` and `2. Discover profiles once during service registration`) actually correct?**
  _`Event` has 11 INFERRED edges - model-reasoned connections that need verification._
- **Are the 3 inferred relationships involving `IApplicationMapper` (e.g. with `Application mapping` and `1. One typed class per source/destination pair`) actually correct?**
  _`IApplicationMapper` has 3 INFERRED edges - model-reasoned connections that need verification._
- **What connects `$schema`, `tasks`, `Mediator` to the rest of the system?**
  _326 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `package.json` be split into smaller, more focused modules?**
  _Cohesion score 0.05647840531561462 - nodes in this community are weakly interconnected._