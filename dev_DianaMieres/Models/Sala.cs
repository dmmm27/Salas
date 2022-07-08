using System;
using System.Collections.Generic;

#nullable disable

namespace dev_DianaMieres.Models
{
    public partial class Sala
    {
        public Sala()
        {
            Reservaciones = new HashSet<Reservacione>();
        }

        public int IdSala { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Reservacione> Reservaciones { get; set; }
    }
}
