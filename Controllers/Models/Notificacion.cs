namespace NotificacionesAPI.Models;

public class Notificacion
{
    public string Destinatario { get; set; } = string.Empty;
    public string Asunto { get; set; } = string.Empty;
    public string Mensaje { get; set; } = string.Empty;
    public DateTime FechaEnvio { get; set; } = DateTime.Now;
}