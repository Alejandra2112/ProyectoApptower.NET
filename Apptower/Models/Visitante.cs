using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Apptower.Models;

public partial class Visitante
{
    public int IdVisitante { get; set; }

    public string TipoDocumentoVisitante { get; set; } = null!;
    [RegularExpression("^[0-9]+$", ErrorMessage = "El número de documento debe contener solo números.")]
    public string? NumeroDocumentoVisitante { get; set; }
    [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "El nombre debe contener solo letras.")]
    public string NombreVisitante { get; set; } = null!;
    [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "El nombre debe contener solo letras.")]
    public string ApellidoVisitante { get; set; } = null!;

    public string? GeneroVisitante { get; set; }

    public string PermisoVisitante { get; set; } = null!;

    public virtual ICollection<VisitantesPorEspacio> VisitantesPorEspacios { get; set; } = new List<VisitantesPorEspacio>();
}
