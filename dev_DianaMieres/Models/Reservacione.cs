using System;
using System.Collections.Generic;

#nullable disable

namespace dev_DianaMieres.Models
{
    public partial class Reservacione
    {
        public int Id { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public bool? Entregado { get; set; }
        public int? IdCliente { get; set; }
        public int? IdSala { get; set; }
        public DateTime? Fecha { get; set; }
        public TimeSpan? HoraInicio { get; set; }
        public TimeSpan? HoraFin { get; set; }

        public virtual Sala IdSalaNavigation { get; set; }
    }
}
