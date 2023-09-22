using System;
using System.Collections.Generic;

namespace Apptower.Models;

public partial class Residente
{
    public int IdResidente { get; set; }

    public string TipoDocumentoResidente { get; set; } = null!;

    public string NumeroDocumentoResidente { get; set; } = null!;

    public string NombreResidente { get; set; } = null!;

    public string ApellidoResidente { get; set; } = null!;

    public DateTime FechaNacimientoResidente { get; set; }

    public string CorreoResidente { get; set; } = null!;

    public string? TelefonoResidente { get; set; }

    public string TipoResidente { get; set; } = null!;

    public bool? ResidenciaActual { get; set; }

    public int IdEspacio { get; set; }

    public DateTime FechaInicioResidencia { get; set; }

    public DateTime? FechaFinResidencia { get; set; }

    public string EstadoResidente { get; set; } = null!;

    public virtual Espacio IdEspacioNavigation { get; set; } = null!;
}
