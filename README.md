# EventsHub

ICI 2026 01

## Graphify before edits

Before creating or changing any file, identify the components involved and query the repository graph from this directory:

```powershell
graphify query "How <xComponent> connects with <yComponent>?"
```

Replace the placeholders with real component names. Use `graphify path "<xComponent>" "<yComponent>"` to inspect a specific connection. Check the source files when the graph does not show enough context.

If `graphify-out/graph.json` does not exist, build it in Codex with `$graphify .`. After changing code, run `graphify update .`. The graph outputs are in [`graphify-out/`](graphify-out/), and the setup guide is in [`docs/guides/install-graphify-openspec.md`](docs/guides/install-graphify-openspec.md).
