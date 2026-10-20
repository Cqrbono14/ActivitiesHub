# Graph Report - EventsHub (2026-10-19)

## Corpus Check

- 90 files · ~127,993 words
- Verdict: corpus is large enough that graph structure adds value.
- Unclassified: 12 file(s) not represented in the graph (top: (none) 10, .nswag 1, .css 1)

## Summary

- 699 nodes · 901 edges · 57 communities (40 shown, 17 thin omitted)
- Extraction: 94% EXTRACTED · 6% INFERRED · 0% AMBIGUOUS · INFERRED: 55 edges (avg confidence: 0.92)
- Token cost: 0 input · 0 output

## Graph Freshness

- Built from commit: `f81d671f`
- Run `git rev-parse HEAD` and compare to check if the graph is stale.
- Run `graphify update .` after code changes (no API cost).

## Community Hubs (Navigation)

- package.json
- EventsHub.Application.Core
- Graphify
- .NET 10 Web API backend
- EventsHub.UnitTests.csproj
- .GetEventsAsync
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
- @mui/material
- Domain event
- EventsHub.Domain layer
- App.tsx
- tsconfig.json
- FalkorDB export
- GraphML export
- Command
- index.d.ts
- Result pattern
- FluentValidation
- EventsHub
- scripts
- Part 1: .NET + npm in the same repo (e.g. EventsHub)
- Part 3: npm only, `package.json` in the repo root (Husky v9)
- .HandlerUpdatesTrackedEntityAndPersistsEveryMappedValue
- .CreateCopiesAllEventProperties
- EventToEventProfile
- 20260829022218_InitialCreate.Designer.cs
- Clean Architecture
- web_src_index
- EF Core DbContext
- automapper
- system_runtime_compilerservices
- CancellationToken
- Software testing
- Proposal
- Tasks
- AppDbContext

## God Nodes (most connected - your core abstractions)

1. `Event` - 36 edges
2. `compilerOptions` - 18 edges
3. `IApplicationMapper` - 15 edges
4. `compilerOptions` - 15 edges
5. `Part 1: .NET + npm in the same repo (e.g. EventsHub)` - 14 edges
6. `Part 2: .NET only (Husky.Net)` - 14 edges
7. `Part 3: npm only, `package.json` in the repo root (Husky v9)` - 14 edges
8. `Handler` - 14 edges
9. `Part 4: npm only, `package.json` in a subfolder (Husky v9)` - 13 edges
10. `AppDbContext` - 13 edges

## Surprising Connections (you probably didn't know these)

- `2. Discover profiles once during service registration` --references--> `Event` [INFERRED]
  openspec/changes/archive/2026-09-29-replace-automapper-with-custom-mapper/design.md → src/EventsHub.Domain/Event.cs
- `Why` --references--> `Event` [INFERRED]
  openspec/changes/archive/2026-09-29-replace-automapper-with-custom-mapper/proposal.md → src/EventsHub.Domain/Event.cs
- `Scenario: Event edit updates a tracked entity` --references--> `Event` [INFERRED]
  openspec/changes/archive/2026-09-29-replace-automapper-with-custom-mapper/specs/application-mapping/spec.md → src/EventsHub.Domain/Event.cs
- `Scenario: Event edit updates a tracked entity` --references--> `Event` [INFERRED]
  openspec/specs/application-mapping/spec.md → src/EventsHub.Domain/Event.cs
- `1. Typed mapper foundation` --references--> `IApplicationMapper` [INFERRED]
  openspec/changes/archive/2026-09-29-replace-automapper-with-custom-mapper/tasks.md → src/EventsHub.Application/Core/IApplicationMapper.cs

## Import Cycles

- None detected.

## Hyperedges (group relationships)

- **EventsHub event read flow** — docs_architecture_web_frontend, docs_architecture_api_backend, docs_architecture_events_controller, docs_architecture_appdbcontext, docs_architecture_sqlite_database [EXTRACTED 1.00]
- **Graphify extraction pipeline** — _agents_skills_graphify_skill_structural_extraction, _agents_skills_graphify_skill_semantic_extraction, _agents_skills_graphify_skill_graph_merge, _agents_skills_graphify_skill_community_detection [EXTRACTED 1.00]

## Communities (57 total, 17 thin omitted)

### Community 0 - "package.json"

Cohesion: 0.10
Nodes (23): @babel/core, babel-plugin-react-compiler, @emotion/react, @emotion/styled, eslint, @eslint/js, eslint-plugin-react-hooks, eslint-plugin-react-refresh (+15 more)

### Community 1 - "EventsHub.Application.Core"

Cohesion: 0.06
Nodes (33): EventsHub.Domain, EventsHub.Application.Events.Queries, EventsHub.UnitTests.Mapping, EventsHub.Application.Events.Commands, EventsHub.UnitTests, EventsHub.Persistence, EventsHub.UnitTests.Controllers, EventsHub.Application.Core (+25 more)

### Community 2 - "Graphify"

Cohesion: 0.06
Nodes (37): Add URL to corpus, Watch mode, Graphify MCP server, Wiki export, Relationship confidence provenance, Deterministic node IDs, Semantic extraction JSON schema, Hyperedges (+29 more)

### Community 3 - ".NET 10 Web API backend"

Cohesion: 0.20
Nodes (11): .NET 10 Web API backend, CORS development origins, Generated API artifacts, EventsHub.OpenApi host, Idempotent event seeding, React and Vite frontend, Generated C# API client, Local NSwag CLI tool (+3 more)

### Community 4 - "EventsHub.UnitTests.csproj"

Cohesion: 0.08
Nodes (23): net10.0, coverlet.collector (6.0.4), MediatR (14.2.0), Microsoft.AspNetCore.Mvc.NewtonsoftJson (10.0.11), Microsoft.AspNetCore.OpenApi (10.0.11), Microsoft.EntityFrameworkCore.Design (10.0.11), Microsoft.EntityFrameworkCore.Sqlite (10.0.11), Microsoft.NET.Test.Sdk (17.14.0) (+15 more)

### Community 5 - ".GetEventsAsync"

Cohesion: 0.06
Nodes (31): ActionResult, ControllerBase, EventsHub.API.Controllers, EventsController, Exception, Handler, HttpDelete, HttpPost (+23 more)

### Community 6 - "baseUri = https://localhost:5001/api/v1"

Cohesion: 0.10
Nodes (25): baseUri = https://localhost:5001/api/v1, 404 Not Found: The event was not found, POST /events/, Events - Create - 200, 404 Not Found: The event was not found, DELETE /events/:eventId, Events - Delete - 200, 404 Not Found: The event was not found (+17 more)

### Community 7 - "Handler"

Cohesion: 0.23
Nodes (12): AppDbContext, 1. One typed class per source/destination pair, 2. Discover profiles once during service registration, 3. Preserve the tracked destination during edits, 4. Fail explicitly for invalid configuration or requests, Context, Decisions, Design (+4 more)

### Community 8 - "compilerOptions"

Cohesion: 0.10
Nodes (19): compilerOptions, allowArbitraryExtensions, allowImportingTsExtensions, erasableSyntaxOnly, jsx, lib, module, moduleDetection (+11 more)

### Community 9 - "dependencies"

Cohesion: 0.22
Nodes (9): dependencies, axios, @emotion/react, @emotion/styled, @fontsource/roboto, @mui/icons-material, @mui/material, react (+1 more)

### Community 10 - "devDependencies"

Cohesion: 0.11
Nodes (18): devDependencies, @babel/core, babel-plugin-react-compiler, eslint, @eslint/js, eslint-plugin-react-hooks, eslint-plugin-react-refresh, globals (+10 more)

### Community 11 - "compilerOptions"

Cohesion: 0.12
Nodes (16): compilerOptions, allowImportingTsExtensions, erasableSyntaxOnly, lib, module, moduleDetection, noEmit, noFallthroughCasesInSwitch (+8 more)

### Community 12 - "AppDbContext"

Cohesion: 0.07
Nodes (31): Command, DbContext, DbContextOptions, DbSet, ILogger, IRequestHandler, List, OneTimeSetUp (+23 more)

### Community 13 - "Event"

Cohesion: 0.15
Nodes (13): DateTime, Event, Category, City, Date, Description, Id, IsCancelled (+5 more)

### Community 14 - "IApplicationMapper"

Cohesion: 0.09
Nodes (22): ArgumentNullException, CancellationToken, Application mapping, Guid, HashSet, InvalidOperationException, IServiceCollection, IServiceProvider (+14 more)

### Community 15 - "ADDED Requirements"

Cohesion: 0.18
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

### Community 23 - "@mui/material"

Cohesion: 0.20
Nodes (10): @mui/material, ActivityCard(), Props, Props, ActivityList(), Props, ActivityDetail(), Props (+2 more)

### Community 24 - "Domain event"

Cohesion: 0.40
Nodes (5): Domain event, Event sourcing, Eventual consistency, Outbox pattern, Saga and process manager

### Community 25 - "EventsHub.Domain layer"

Cohesion: 0.67
Nodes (3): EventsHub.Application layer, EventsHub.Domain layer, EventsHub.Persistence layer

### Community 26 - "App.tsx"

Cohesion: 0.21
Nodes (10): axios, @fontsource/roboto, @mui/icons-material, react, react-dom, App(), NavBar(), Props (+2 more)

### Community 30 - "Command"

Cohesion: 0.22
Nodes (10): Application layer, CQRS, Command, Command Query Responsibility Segregation, Dispatcher and handlers, Idempotency, Pipeline behavior, Query (+2 more)

### Community 35 - "scripts"

Cohesion: 0.40
Nodes (5): scripts, build, dev, lint, preview

### Community 36 - "Part 1: .NET + npm in the same repo (e.g. EventsHub)"

Cohesion: 0.04
Nodes (46): How to use this guide, Installing Husky in a Project: .NET and npm, Optional: add Prettier (code formatting), Optional: add Prettier (code formatting), Part 1: .NET + npm in the same repo (e.g. EventsHub), Part 2: .NET only (Husky.Net), Part 4: npm only, `package.json` in a subfolder (Husky v9), Skipping hooks (use sparingly) (+38 more)

### Community 37 - "Part 3: npm only, `package.json` in the repo root (Husky v9)"

Cohesion: 0.13
Nodes (15): Optional: add Prettier (code formatting), Part 3: npm only, `package.json` in the repo root (Husky v9), Skipping hooks (use sparingly), Step 10: Commit the Husky files, Step 11: Setup for a new teammate or CI, Step 1: Check prerequisites, Step 2: Make sure `package.json` and `.gitignore` exist, Step 3: Install Husky (+7 more)

### Community 38 - ".HandlerUpdatesTrackedEntityAndPersistsEveryMappedValue"

Cohesion: 0.27
Nodes (7): Event, Command, Event, Event, Task, Test, EditEventMappingTests

### Community 39 - ".CreateCopiesAllEventProperties"

Cohesion: 0.62
Nodes (3): Event, Test, EventToEventProfileTests

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

Cohesion: 0.18
Nodes (8): Capabilities, Impact, Modified Capabilities, New Capabilities, Proposal, What Changes, Why, EditEvent

### Community 62 - "Tasks"

Cohesion: 0.40
Nodes (4): 1. Typed mapper foundation, 2. Replace the current Event mapping, 3. Integration verification, Tasks

### Community 64 - "AppDbContext"

Cohesion: 0.33
Nodes (6): AppDbContext, Clean Architecture implementation gap, Controller-to-EF Core access, Event entity, EventsController, SQLite eventshub.db

## Knowledge Gaps

- **301 isolated node(s):** `How to use this guide`, `Where to run the commands (read this once)`, `Step 1: Check prerequisites`, `Step 2: Install Husky.Net as a local tool`, `Step 3: Install the Git hooks` (+296 more)
  These have ≤1 connection - possible missing edges or undocumented components. (Counts symbols only; 383 node(s) total have ≤1 connection when file, concept and rationale nodes are included.)
- **17 thin communities (<3 nodes) omitted from report** — run `graphify query` to explore isolated nodes.

## Suggested Questions

_Questions this graph is uniquely positioned to answer:_

- **Why does `Event` connect `Event` to `EventsHub.Application.Core`, `.GetEventsAsync`, `Handler`, `AppDbContext`, `ADDED Requirements`, `Requirements`, `Proposal`, `Tasks`?**
  _High betweenness centrality (0.080) - this node is a cross-community bridge._
- **Why does `IApplicationMapper` connect `IApplicationMapper` to `EventsHub.Application.Core`, `.HandlerUpdatesTrackedEntityAndPersistsEveryMappedValue`, `.CreateCopiesAllEventProperties`, `Handler`, `Tasks`?**
  _High betweenness centrality (0.033) - this node is a cross-community bridge._
- **Why does `AppDbContext` connect `AppDbContext` to `EventsHub.Application.Core`, `Event`, `Handler`?**
  _High betweenness centrality (0.029) - this node is a cross-community bridge._
- **Are the 11 inferred relationships involving `Event` (e.g. with `1. One typed class per source/destination pair` and `2. Discover profiles once during service registration`) actually correct?**
  _`Event` has 11 INFERRED edges - model-reasoned connections that need verification._
- **Are the 3 inferred relationships involving `IApplicationMapper` (e.g. with `Application mapping` and `1. One typed class per source/destination pair`) actually correct?**
  _`IApplicationMapper` has 3 INFERRED edges - model-reasoned connections that need verification._
- **What connects `How to use this guide`, `Where to run the commands (read this once)`, `Step 1: Check prerequisites` to the rest of the system?**
  _301 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `package.json` be split into smaller, more focused modules?**
  _Cohesion score 0.10153846153846154 - nodes in this community are weakly interconnected._
