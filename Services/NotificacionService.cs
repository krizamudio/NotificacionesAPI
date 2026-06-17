using NotificacionesAPI.Models;

namespace NotificacionesAPI.Services;

public class NotificacionService
{
    private readonly List<Notificacion> _notificaciones = new();

    public List<Notificacion> ObtenerTodas()
    {
        return _notificaciones;
    }

    public Notificacion Registrar(Notificacion notificacion)
    {
        notificacion.FechaEnvio = DateTime.Now;
        _notificaciones.Add(notificacion);
        return notificacion;
    }
}