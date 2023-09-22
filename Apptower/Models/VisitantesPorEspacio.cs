using System;
using System.Collections.Generic;

namespace Apptower.Models;

public partial class VisitantesPorEspacio
{
    public int IdVisitantePorEspacio { get; set; }

    public int? IdEspacio { get; set; }

    public int? IdVisitante { get; set; }

    public virtual Espacio? IdEspacioNavigation { get; set; }

    public virtual Visitante? IdVisitanteNavigation { get; set; }
}
