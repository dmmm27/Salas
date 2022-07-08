using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dev_DianaMieres.Models
{
    public class ListadoReservaciones
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public string Sala { get; set; }
        public DateTime fecha { get; set; }
        public TimeSpan horaInicio { get; set; }
        public TimeSpan horaFin { get; set; }
    }
}
