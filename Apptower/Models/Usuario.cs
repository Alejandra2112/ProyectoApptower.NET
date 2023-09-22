using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Apptower.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    [Required(ErrorMessage = "El campo Nombre es requerido.")]
    [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "El campo Nombre solo puede contener letras.")]
    public string? Nombre { get; set; }

    [Required(ErrorMessage = "El campo Nombre es requerido.")]
    [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "El campo Apellido solo puede contener letras.")]
    public string? Apellido { get; set; }

    public int? IdRol { get; set; }

    public string? TipoDocumento { get; set; }

    [Required(ErrorMessage = "El campo Documento es requerido.")]
    [RegularExpression(@"^\d{8,10}$", ErrorMessage = "El campo Documento debe contener entre 8 y 10 números.")]
    public string? Documento { get; set; }

    [Required(ErrorMessage = "El campo Correo es requerido.")]
    [EmailAddress(ErrorMessage = "El campo Correo debe ser una dirección de correo electrónico válida.")]
    public string? Correo { get; set; }

    public DateTime? FechaCreacion { get; set; }
    public string? Estado { get; set; }

    [Required(ErrorMessage = "El campo Teléfono es requerido.")]
    [RegularExpression(@"^\d{8,10}$", ErrorMessage = "El campo Teléfono debe solo numeros.")]
    public string? Telefono { get; set; }

    public string? Contrasena { get; set; }

    public virtual ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
}
