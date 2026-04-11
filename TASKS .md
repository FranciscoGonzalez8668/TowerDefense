# TASKS – TP Turret Defense

## 🔄 En progreso
- [ ] TP Turret Defense

---

## ⏳ Pendiente

### Consigna 1 — Coroutine de spawn + movimiento del enemigo
- [ ] Crear Prefab "Enemy" con Rigidbody y Collider
- [ ] Crear script `EnemyMover.cs` — mueve el enemigo hacia adelante (forward)
- [ ] Agregar velocidad aleatoria entre un rango (ej. 2f a 5f)
- [ ] Agregar zigzag leve con Mathf.Sin
- [ ] Crear script `EnemySpawner.cs` con Coroutine
- [ ] Spawnear enemigo periódicamente con la rotación del spawner
- [ ] Probar que los enemigos aparecen y caminan correctamente

### Consigna 2 — Torreta que gira con el mouse
- [ ] Crear GameObject "Turret" en la escena
- [ ] Crear script `TurretRotator.cs`
- [ ] Leer Input.mouseScrollDelta para rotar la torreta
- [ ] Probar que la torreta gira suave con el scroll

### Consigna 3 — EnemyManager con CheckFinish
- [ ] Crear script `EnemyManager.cs`
- [ ] Guardar referencia a todos los enemigos en una lista
- [ ] Implementar método `CheckFinish()`
- [ ] Si más de la mitad están desactivados → Debug.Log("You Win")
- [ ] Probar manualmente desactivando enemigos desde el editor

### Consigna 4 — Proyectil con colisión
- [ ] Crear Prefab "Projectile" con Rigidbody y Collider
- [ ] Crear script `ProjectileMover.cs` — se mueve hacia adelante
- [ ] Crear script `ProjectileCollision.cs`
- [ ] Al colisionar con enemigo: desactivar enemigo, llamar CheckFinish(), desactivar proyectil
- [ ] Agregar scripts al Prefab del proyectil
- [ ] Probar colisión en escena

### Consigna 5 — Disparo desde la torreta
- [ ] Agregar disparo al click izquierdo en `TurretRotator.cs` o script nuevo
- [ ] Instanciar proyectil desde el cañón de la torreta con su rotación
- [ ] Probar ciclo completo: girar → apuntar → disparar → eliminar enemigo

### Armado final de la escena
- [ ] Diseñar tablero con zona central para la torreta
- [ ] Posicionar spawners en los bordes
- [ ] Ajustar velocidad, cadencia de spawn y cantidad de enemigos
- [ ] Probar condición de victoria

### Entrega
- [ ] Comprimir proyecto en ZIP
- [ ] Subir ZIP al Drive y dejar link público
- [ ] Entregar en doctaonline.com

---

## ✅ Terminado
- [x] TP1 – Generación de Ideas
- [x] TP2 – Basic Projectile
- [x] TP3 – Plinko

---

## 📝 Notas de sesiones

| Fecha | Tarea | Resultado | Notas |
|-------|-------|-----------|-------|
| -     | Setup | CLAUDE.md + TASKS.md listos | Arrancar por Consigna 1 |
