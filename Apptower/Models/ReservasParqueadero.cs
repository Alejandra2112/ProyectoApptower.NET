using System;
using System.Collections.Generic;

namespace Apptower.Models;

public partial class ReservasParqueadero
{
    public int IdReservaEspacios { get; set; }

    public int? IdReserva { get; set; }

    public int? IdParqueadero { get; set; }

    public int? IdVehiculo { get; set; }

    public virtual Parqueadero? IdParqueaderoNavigation { get; set; }

    public virtual Reserva? IdReservaNavigation { get; set; }

    public virtual Vehiculo? IdVehiculoNavigation { get; set; }
}
