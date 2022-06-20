using System;
using System.Collections.Generic;

#nullable disable

namespace RepositoReplicado
{
    public partial class Doctore
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int EspecialidadId { get; set; }
        public int HospitalId { get; set; }
        public DateTime FechaDeNacimiento { get; set; }

        public virtual Especialidade Especialidad { get; set; }
        public virtual Hospitale Hospital { get; set; }
    }
}
