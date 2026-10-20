# Instalar Graphify y OpenSpec para Codex en EventsHub

Esta guía describe herramientas de desarrollo globales. No agregan dependencias a los proyectos .NET ni al frontend.

## Graphify

Requiere Python 3.10+ y `uv` o `pipx`.

```powershell
uv tool install graphifyy
graphify --version
```

El skill de este repositorio está en `.agents/skills/graphify/SKILL.md` y las reglas de proyecto en `AGENTS.md`. Al abrir una sesión nueva de Codex desde la raíz, solicita:

```text
/graphify .
```

Codex debe interpretar esa solicitud como la ejecución del skill con `.` como directorio de entrada. La invocación explícita del skill es `$graphify .`; también puedes elegirlo desde `/skills`. En una terminal sin Codex, usa `graphify .`. `/graphify` es texto dirigido al agente, no un comando de PowerShell.

Para instalar la integración de Graphify en otro repositorio, usa `graphify install --platform codex --project`. El instalador genérico sin `--platform codex` puede elegir otra plataforma.

`.graphifyignore` excluye dependencias, binarios y código generado. Después de construir el grafo, comprueba que `graphify-out/graph.json`, `graphify-out/GRAPH_REPORT.md` y `graphify-out/graph.html` contengan entidades de `src/` y `web/src/`.

Para actualizar el grafo tras cambios de código:

```powershell
graphify update .
```

Para instalar el hook de actualización por commit en cada máquina:

```powershell
graphify hook install
graphify hook status
```

Los hooks viven en `.git/hooks/` y no se comparten mediante Git. No sustituyen la actualización semántica de documentos e imágenes.

## OpenSpec

Requiere Node.js 20.19.0+.

```powershell
npm install -g @fission-ai/openspec@latest
openspec --version
openspec init --tools codex
```

OpenSpec genera skills en `.agents/skills/openspec-*/SKILL.md` para Codex. Su integración con Codex usa skills, no comandos personalizados `/opsx:*`. Invoca un flujo con el skill correspondiente, por ejemplo `$openspec-propose`. Comprueba la instalación con `openspec list` y `openspec validate`.

Antes de confirmar cambios, revisa `git status`. Los archivos de configuración y skills del repositorio pueden versionarse; cada colaborador instala los CLI y hooks en su propia máquina.
