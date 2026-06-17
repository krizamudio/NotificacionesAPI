using Microsoft.AspNetCore.Mvc;
using NotificacionesAPI.Models;
using NotificacionesAPI.Services;

namespace NotificacionesAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NotificacionesController : ControllerBase
{
    private readonly NotificacionService _service;

    public NotificacionesController(NotificacionService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_service.ObtenerTodas());
    }

    [HttpPost]
    public IActionResult Enviar([FromBody] Notificacion notificacion)
    {
        var resultado = _service.Registrar(notificacion);
        return Ok(new { mensaje = "✅ Notificación registrada", datos = resultado });
    }
}