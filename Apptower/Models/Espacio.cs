using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Apptower.Models;

public partial class Espacio
{
    public int IdEspacio { get; set; }

    [StringLength(15, ErrorMessage = "Nombre de espacio no es valido")]
    [Required(ErrorMessage = "Nombre es obligatoria")]
    [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Nombre no es valido")]
    public string? NombreEspacio { get; set; }



    [RegularExpression("^(APARTAMENTO|SALON SOCIAL|ZONA HUMEDA)$", ErrorMessage = "Tipo de espacio no válido. Use 'APARTAMENTO' o 'SALON SOCIAL' o 'ZONA HUMEDA' .")]
    public string TipoEspacio { get; set; } = null!;

    [Range(0,500, ErrorMessage = "El area debe estar entre 1 y 500")]
    public double? Area { get; set; }
    [Range(0, 500, ErrorMessage = "El area debe estar entre 1 y 10000")]
    public int? Capacidad { get; set; }

    public string EstadoEspacio { get; set; } = null!;

    public virtual ICollection<ParqueaderosDeEspacio
        > ParqueaderosDeEspacios { get; set; } = new List<ParqueaderosDeEspacio>();

    public virtual ICollection<PropietariosPorEspacio>? PropietariosPorEspacios { get; set; } = new List<PropietariosPorEspacio>();

    public virtual ICollection<ReservasEspacio> ReservasEspacios { get; set; } = new List<ReservasEspacio>();

    public virtual ICollection<Residente> Residentes { get; set; } = new List<Residente>();

    public virtual ICollection<VehiculosPorEspacio> VehiculosPorEspacios { get; set; } = new List<VehiculosPorEspacio>();

    public virtual ICollection<VisitantesPorEspacio> VisitantesPorEspacios { get; set; } = new List<VisitantesPorEspacio>();
}
