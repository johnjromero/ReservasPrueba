using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ReservasBackend.Models
{
    public partial class TipoAlojamiento
    {
        public TipoAlojamiento()
        {
            CupoSedeAlojamiento = new HashSet<CupoSedeAlojamiento>();
        }

        public int TipoAlojamientoId { get; set; }
        public string TipoAlojamientoNombre { get; set; }

        public virtual ICollection<CupoSedeAlojamiento> CupoSedeAlojamiento { get; set; }
    }
}
