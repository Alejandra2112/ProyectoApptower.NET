using System;
using System.Collections.Generic;

namespace Apptower.Models;

public partial class VehiculosPorEspacio
{
    public int IdVehiculosPorEspacio { get; set; }

    public int? IdEspacio { get; set; }

    public int? IdVehiculo { get; set; }

    public virtual Espacio? IdEspacioNavigation { get; set; }

    public virtual Vehiculo? IdVehiculoNavigation { get; set; }
}
