using System;
using System.Collections.Generic;

namespace Apptower.Models;

public partial class ParqueaderosDeEspacio
{
    public int IdParqueaderosDeEspacios { get; set; }

    public int? IdEspacio { get; set; }

    public int? IdParqueadero { get; set; }

    public virtual Espacio? IdEspacioNavigation { get; set; }

    public virtual Parqueadero? IdParqueaderoNavigation { get; set; }
}
