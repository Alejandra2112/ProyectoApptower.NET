using System;
using System.Collections.Generic;

namespace Apptower.Models;

public partial class Vehiculo
{
    public int IdVehiculo { get; set; }

    public string Placa { get; set; } = null!;

    public string TipoUsuarioVehiculo { get; set; }

    public string NombrePropietarioVehiculo { get; set; }

    public virtual ICollection<ReservasParqueadero> ReservasParqueaderos { get; set; } = new List<ReservasParqueadero>();

    public virtual ICollection<VehiculosPorEspacio> VehiculosPorEspacios { get; set; } = new List<VehiculosPorEspacio>();
}
