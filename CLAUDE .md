# AI Context File – TP Turret Defense (My Project)

## Proyecto
Trabajo práctico de la diplomatura de videojuegos. Se implementa un juego de defensa de torretas en Unity 3D.

- **Motor:** Unity 6.3.6 — C#
- **Proyecto Unity:** My Project
- **Desarrollador:** 1 persona, nivel intermedio

## Lo que ya existe en el proyecto
- TPs anteriores completados (pelotas cayendo, Basic Projectile, Plinko)

---

## El juego — Turret Defense 3D

### Concepto
Una torreta fija en el centro de la escena. Enemigos spawnean periódicamente desde los bordes y caminan hacia la torreta. El jugador apunta girando la torreta con la rueda del mouse y dispara proyectiles para eliminarlos. Si elimina más de la mitad de los enemigos spawneados → "You Win".

### Mecánicas
- **Torreta:** gira sobre su eje con la rueda del mouse
- **Enemigos:** spawnean periódicamente con una Coroutine, se mueven hacia adelante (forward) con velocidad aleatoria y zigzag leve
- **Proyectil:** se mueve hacia adelante, al colisionar con un enemigo lo desactiva y llama al Manager
- **Manager:** controla la colección de enemigos, si más de la mitad están desactivados → Debug "You Win"

---

## Consignas del TP (mapeo técnico)

### Consigna 1 — Coroutine de spawn
- Script con Coroutine que spawnea un Prefab periódicamente
- Le asigna la rotación del GameObject spawner (forward)
- El Prefab tiene un script que lo mueve hacia adelante

### Consigna 2 — Girar con rueda del mouse
- Script que rota un GameObject según el scroll del mouse
- Se aplica a la torreta

### Consigna 3 — Manager con CheckFinish
- `EnemyManager.cs` con método `CheckFinish()`
- Controla una colección de todos los enemigos
- Si más de la mitad están desactivados → Debug.Log("You Win")

### Consigna 4 — Proyectil con colisión
- Al colisionar con otro GameObject: llama a `CheckFinish()` del Manager y se desactiva
- Se agrega al Prefab del proyectil

### Consigna 5 — Movimiento del enemigo
- Velocidad aleatoria entre un rango definido
- Zigzag leve mientras avanza (oscilación lateral con Mathf.Sin)

---

## Instrucciones para Claude Code
- Guiarme paso a paso — no tirar todo el código de una
- Explicar brevemente qué hace cada script antes de escribirlo
- Código C# listo para copiar en Unity, con comentarios claros
- Avisar si algo puede romper lo que ya existe en el proyecto
- Al terminar cada parte, decirme qué marcar como hecho en TASKS.md
