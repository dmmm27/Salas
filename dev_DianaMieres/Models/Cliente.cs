using System;
using System.Collections.Generic;

#nullable disable

namespace dev_DianaMieres.Models
{
    public partial class Cliente
    {
        public int IdCliente { get; set; }
        public string Dpi { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }
}
