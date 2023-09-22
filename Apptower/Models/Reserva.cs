using System;
using System.Collections.Generic;

namespace Apptower.Models;

public partial class Reserva
{
    public int IdReserva { get; set; }

    public int? IdUsuario { get; set; }

    public string TipoReserva { get; set; } = null!;

    public DateTime FechaReserva { get; set; }

    public string EspacioReserva { get; set; } = null!;

    public int CantidadPersonas { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }

    public virtual ICollection<ReservasEspacio> ReservasEspacios { get; set; } = new List<ReservasEspacio>();

    public virtual ICollection<ReservasParqueadero> ReservasParqueaderos { get; set; } = new List<ReservasParqueadero>();
}
