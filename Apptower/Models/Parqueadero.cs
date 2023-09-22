using System;
using System.Collections.Generic;

namespace Apptower.Models;

public partial class Parqueadero
{
    public int IdParqueadero { get; set; }

    public string NombreParqueadero { get; set; } = null!;

    public string TipoParqueadero { get; set; } = null!;

    public string? EstadoParqueadero { get; set; }

    public virtual ICollection<ParqueaderosDeEspacio> ParqueaderosDeEspacios { get; set; } = new List<ParqueaderosDeEspacio>();

    public virtual ICollection<ReservasParqueadero> ReservasParqueaderos { get; set; } = new List<ReservasParqueadero>();
}
