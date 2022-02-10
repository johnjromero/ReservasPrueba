using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ReservasBackend.Models
{
    public partial class CupoSedeAlojamiento
    {
        public int CupoSedeAlojamientoId { get; set; }
        public int SedeId { get; set; }
        public decimal NumeroHabiaciones { get; set; }
        public int TipoAlojamientoId { get; set; }

        public virtual Sede Sede { get; set; }
        public virtual TipoAlojamiento TipoAlojamiento { get; set; }
    }
}
