using System;
using System.Collections.Generic;

#nullable disable

namespace dev_DianaMieres.Models
{
    public partial class Fecha
    {
        public int Id { get; set; }
        public TimeSpan? HoraInicio { get; set; }
        public TimeSpan? HoraFin { get; set; }
        public DateTime? FechaActual { get; set; }
        public bool? Entregado { get; set; }
    }
}
