# graphify reference: commit hook and Codex project instructions

Load this when the user asks for a post-commit hook or Codex project integration.

## Git commit hook

```powershell
graphify hook install
graphify hook status
graphify hook uninstall
```

The hook updates the AST-derived graph after commits. For document or image changes, run `/graphify . --update` manually.

## Codex integration

Keep the project rules in the root `AGENTS.md` and the reusable workflow in `.agents/skills/graphify/SKILL.md`. Codex discovers repository skills from `.agents/skills`. An explicit `$graphify .` or a request such as `/graphify .` should run the build workflow. `graphify install --platform codex --project` is available when setting up another repository.
