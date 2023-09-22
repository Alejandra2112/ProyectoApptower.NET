using System;
using System.Collections.Generic;

namespace Apptower.Models;

public partial class PropietariosPorEspacio
{
    public int IdPropietariosPorEspacio { get; set; }

    public int? IdEspacio { get; set; }

    public int? IdPropietario { get; set; }

    public virtual Espacio? IdEspacioNavigation { get; set; }

    public virtual Propietario? IdPropietarioNavigation { get; set; }
}
