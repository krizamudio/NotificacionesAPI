using Microsoft.AspNetCore.Mvc;

namespace NotificacionesAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NotificacionesController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok("✅ API de notificaciones funcionando");
    }

    [HttpPost]
    public IActionResult Enviar([FromBody] string mensaje)
    {
        return Ok($"📨 Notificación enviada: {mensaje}");
    }
}