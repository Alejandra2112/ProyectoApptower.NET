using System;
using System.Collections.Generic;

namespace Apptower.Models;

public partial class ReservasEspacio
{
    public int IdReservaEspacios { get; set; }

    public int? IdReserva { get; set; }

    public int? IdEspacio { get; set; }

    public virtual Espacio? IdEspacioNavigation { get; set; }

    public virtual Reserva? IdReservaNavigation { get; set; }
}
