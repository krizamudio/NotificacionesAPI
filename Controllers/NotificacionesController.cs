using Microsoft.AspNetCore.Mvc;
using NotificacionesAPI.Models;

namespace NotificacionesAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NotificacionesController : ControllerBase
{
    private static List<Notificacion> _notificaciones = new();

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_notificaciones);
    }

    [HttpPost]
    public IActionResult Enviar([FromBody] Notificacion notificacion)
    {
        _notificaciones.Add(notificacion);
        return Ok(new { mensaje = "✅ Notificación registrada", datos = notificacion });
    }
}