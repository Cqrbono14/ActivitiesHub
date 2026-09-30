# Graphify en Codex

- El skill del repositorio está en `.agents/skills/graphify/SKILL.md`.
- Antes de crear o modificar cualquier archivo, identifica los componentes o conceptos afectados y consulta el grafo con `graphify query "How <xComponent> connects with <yComponent>?"`, sustituyendo ambos nombres reales. Si no existe el grafo, genéralo con `$graphify .` primero; si la consulta no aclara la relación, revisa los archivos fuente.
- Cuando el usuario escriba `/graphify` con argumentos (por ejemplo, `/graphify .`), interpreta el texto como una solicitud de ejecutar el skill `graphify` con esos argumentos. Lee el skill y sigue su flujo. `.` significa la raíz de trabajo actual.
- También se puede invocar explícitamente con `$graphify` o seleccionarlo mediante `/skills`.
- Si existe `graphify-out/graph.json`, para preguntas sobre el código consulta primero `graphify query "<pregunta>"`; usa `graphify path` y `graphify explain` según el caso.
- Después de modificar código, si existe un grafo previo, ejecuta `graphify update .` para mantenerlo actualizado.
