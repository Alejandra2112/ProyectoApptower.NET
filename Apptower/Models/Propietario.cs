using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Apptower.Models;

public partial class Propietario
{
    public int IdPropietario { get; set; }

    public string TipoDocumentoPropietario { get; set; }

    [Required(ErrorMessage = "El campo Documento es requerido.")]
    [RegularExpression(@"^\d{8,10}$", ErrorMessage = "El campo Documento debe contener entre 8 y 10 números.")]
    public string NumeroDocumentoPropietario { get; set; }

    [Required(ErrorMessage = "El campo Nombre es requerido.")]
    [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "El campo Nombre solo puede contener letras.")]
    public string NombrePropietario { get; set; }

    [Required(ErrorMessage = "El campo Nombre es requerido.")]
    [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "El campo Apellido solo puede contener letras.")]
    public string ApellidoPropietario { get; set; } 

    [Required(ErrorMessage = "El campo Nombre es requerido.")]
    public DateTime FechaNacimientoPropietario { get; set; }

    [Required(ErrorMessage = "El campo Correo es requerido.")]
    [EmailAddress(ErrorMessage = "El campo Correo debe ser una dirección de correo electrónico válida.")]
    public string CorreoPropietario { get; set; }

    [Required(ErrorMessage = "El campo Teléfono es requerido.")]
    [RegularExpression(@"^\d{8,10}$", ErrorMessage = "El campo Teléfono debe solo numeros.")]
    public string? TelefonoPropietario { get; set; }

    public string EstadoPropietario { get; set; } 

    public virtual ICollection<PropietariosPorEspacio> PropietariosPorEspacios { get; set; } = new List<PropietariosPorEspacio>();
}
