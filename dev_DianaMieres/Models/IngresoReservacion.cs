using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dev_DianaMieres.Models
{
    [Keyless]
    public class IngresoReservacion
    {
        
        public string horaInicio { get; set; }
        public string HoraFin { get; set; }
        public int idSala { get; set; }

        public string status { get; set; }
    }
}
