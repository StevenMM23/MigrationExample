using System;
using System.Collections.Generic;

#nullable disable

namespace RepositoReplicado
{
    public partial class Hospitale
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public virtual Doctore Doctore { get; set; }
    }
}
