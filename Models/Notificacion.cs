using System.ComponentModel.DataAnnotations;

namespace NotificacionesAPI.Models;

public class Notificacion
{
    [Required(ErrorMessage = "El destinatario es obligatorio")]
    [EmailAddress(ErrorMessage = "El destinatario debe ser un email válido")]
    public string Destinatario { get; set; } = string.Empty;

    [Required(ErrorMessage = "El asunto es obligatorio")]
    [MaxLength(100, ErrorMessage = "El asunto no puede superar 100 caracteres")]
    public string Asunto { get; set; } = string.Empty;

    [Required(ErrorMessage = "El mensaje es obligatorio")]
    [MinLength(5, ErrorMessage = "El mensaje debe tener al menos 5 caracteres")]
    public string Mensaje { get; set; } = string.Empty;

    public DateTime FechaEnvio { get; set; } = DateTime.Now;
}