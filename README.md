# NotificacionesAPI

> API simple para registrar y listar notificaciones en memoria. Construida con .NET 10 y con soporte para Swagger en entorno de desarrollo.

## Características

- Registrar notificaciones (POST `/api/notificaciones`).
- Listar todas las notificaciones registradas (GET `/api/notificaciones`).
- Modelo con validaciones básicas (`Destinatario`, `Asunto`, `Mensaje`).
- Documentación automática con Swagger en desarrollo.

## Estructura relevante

- Controlador: [Controllers/NotificacionesController.cs](Controllers/NotificacionesController.cs#L1-L200)
- Modelo: [Models/Notificacion.cs](Models/Notificacion.cs#L1-L200)
- Servicio en memoria: [Services/NotificacionService.cs](Services/NotificacionService.cs#L1-L200)
- Entrada de la app: [Program.cs](Program.cs#L1-L200)

## Requisitos

- .NET 10 SDK

Comprobar versión instalada:

```powershell
dotnet --version
```

## Instalación y ejecución

1. Restaurar dependencias:

```powershell
dotnet restore
```

2. Ejecutar la API en modo desarrollo:

```powershell
dotnet run
```

3. Abrir Swagger (solo en `Development`) en `https://localhost:{puerto}/swagger`.

## Endpoints

- GET `/api/notificaciones`
  - Descripción: Devuelve la lista de notificaciones en memoria.
  - Respuesta: JSON array de objetos `Notificacion`.

- POST `/api/notificaciones`
  - Descripción: Registra una nueva notificación en memoria.
  - Body (JSON):

```json
{
  "destinatario": "usuario@ejemplo.com",
  "asunto": "Prueba",
  "mensaje": "Este es el contenido de la notificación"
}
```
  - Respuesta: objeto con mensaje de confirmación y los datos registrados.

Ejemplo `curl`:

```bash
curl -k -X POST https://localhost:5001/api/notificaciones \
  -H "Content-Type: application/json" \
  -d '{"destinatario":"user@example.com","asunto":"Hola","mensaje":"Prueba"}'
```

> Nota: `-k` ignora certificados en entornos locales si se usa HTTPS auto-firmado.

## Modelo `Notificacion`

Propiedades principales (ver [Models/Notificacion.cs](Models/Notificacion.cs#L1-L200)):

- `Destinatario` (string, requerido, email válido)
- `Asunto` (string, requerido, max 100 caracteres)
- `Mensaje` (string, requerido, min 5 caracteres)
- `FechaEnvio` (DateTime, asignado al registrar)

## Desarrollo y pruebas

- El servicio de notificaciones es un singleton en memoria (`NotificacionService`) — no persiste entre reinicios.
- Para pruebas rápidas usar Swagger UI o `curl`/Postman.

## Siguientes pasos sugeridos

- Añadir persistencia (BD) si se requiere almacenamiento duradero.
- Agregar autenticación/autorización para proteger los endpoints.
- Añadir tests unitarios e integración.

## Licencia

Proyecto de ejemplo — añade licencia si corresponde.

---

Si quieres, puedo: añadir un `README` más detallado (ej. instrucciones de Docker), crear tests básicos, o preparar un archivo `launchSettings.json` para debugging. ¿Qué prefieres?
